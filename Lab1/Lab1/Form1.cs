using System;
using System.Collections.Frozen;
using System.Reflection;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public static readonly int LenOfAlfavit = 33;

        public static readonly FrozenDictionary<char, long> LetterToIndex = new Dictionary<char, long>()
        { {'а', 0 }, {'б', 1 }, {'в', 2 }, {'г', 3 }, {'д', 4 }, {'е', 5 }, {'ё', 6 }, {'ж', 7 },
          {'з', 8 }, {'и', 9 }, {'й', 10 },{'к', 11 },{'л', 12 },{'м', 13 },{'н', 14 },{'о', 15 },
          {'п', 16 },{'р', 17 },{'с', 18 },{'т', 19 },{'у', 20 },{'ф', 21 },{'х', 22 },{'ц', 23 },
          {'ч', 24 },{'ш', 25 },{'щ', 26 },{'ъ', 27 },{'ы', 28 },{'ь',29 }, {'э', 30 },{'ю', 31 },
          {'я', 32 }}.ToFrozenDictionary();

        public static readonly string IndexToLetter = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public enum ShipherType
        {
            Decimazii,
            Vijener
        }
        public enum ShipherFunction
        {
            Shipher,
            DeShipher
        }

        private ShipherType SelectedShipherType { get; set; } = ShipherType.Decimazii;
        private ShipherFunction SelectedShipherFunction { get; set; } = ShipherFunction.Shipher;


        #region Метод децимаций
        public bool CheckDezimaziiKey(long value)
        {
            long k = value;
            long l = LenOfAlfavit;

            while (l != 0 && k != 0)
            {
                if (k > l) k %= l;
                else l %= k;
            }
            return (k + l) == 1;
        }

        public string EncryptDezimaziiText(string str, long key)
        {
            textDataGridView.Columns.Add("clearColumn", "Исходный символ");
            textDataGridView.Rows.Add();
            textDataGridView.Rows[0].Cells[0].Value = "Полученный индекс";
            textDataGridView.Rows.Add();
            textDataGridView.Rows[1].Cells[0].Value = "Итоговый символ";

            string shiphroText = ""; int indexData = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (LetterToIndex.ContainsKey(char.ToLower(str[i])))
                {
                    long? index = (LetterToIndex[char.ToLower(str[i])] * key) % LenOfAlfavit;
                    shiphroText += IndexToLetter[(int)index];

                    textDataGridView.Columns.Add((str[i] + i).ToString(), str[i].ToString());
                    textDataGridView.Rows[0].Cells[indexData + 1].Value = LetterToIndex[char.ToLower(str[i])] +
                        "*" + key + "%" + LenOfAlfavit + "=" + index;
                    textDataGridView.Rows[1].Cells[indexData + 1].Value = shiphroText[^1];
                    indexData++;
                }
                else if (!char.IsLetter(str[i]))
                {
                    shiphroText += str[i];
                }
            }

            foreach (DataGridViewColumn column in textDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            return shiphroText;
        }

        public long InverseKey(long k)
        {
            k %= LenOfAlfavit;
            for (int x = 1; x < LenOfAlfavit; x++)
            {
                if ((k * x) % LenOfAlfavit == 1)
                    return x;
            }
            return 0;
        }

        public string DecryptDezimaziiText(string str, long key)
        {
            textDataGridView.Columns.Add("clearColumn", "Исходный символ");
            textDataGridView.Rows.Add();
            textDataGridView.Rows[0].Cells[0].Value = "Полученный индекс";
            textDataGridView.Rows.Add();
            textDataGridView.Rows[1].Cells[0].Value = "Итоговый символ";


            string plainText = ""; int indexData = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (LetterToIndex.ContainsKey(char.ToLower(str[i])))
                {
                    long? index = (LetterToIndex[char.ToLower(str[i])] * InverseKey(key)) % LenOfAlfavit;
                    plainText += IndexToLetter[(int)index];

                    textDataGridView.Columns.Add((str[i] + i).ToString(), str[i].ToString());
                    textDataGridView.Rows[0].Cells[indexData + 1].Value = LetterToIndex[char.ToLower(str[i])] +
                        "*" + InverseKey(key) + "%" + LenOfAlfavit + "=" + index;
                    textDataGridView.Rows[1].Cells[indexData + 1].Value = plainText[^1];
                    indexData++;
                }
                else if (!char.IsLetter(str[i]))
                {
                    plainText += str[i];
                }
            }

            foreach (DataGridViewColumn column in textDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            return plainText;
        }
        #endregion


        public string EncryptVijenerText(string str, string secretKey)
        {
            textDataGridView.Columns.Add("clearColumn", "Исходный символ");
            textDataGridView.Rows.Add();
            textDataGridView.Rows[0].Cells[0].Value = "Буква ключа";
            textDataGridView.Rows.Add();
            textDataGridView.Rows[1].Cells[0].Value = "Итоговый символ";

            string fullKey = (secretKey + str).ToLower().Replace('\n', ' ').Replace('\t', ' ').Replace(" ", "");
            string shiphroText = "";
            int keyPointer = 0;
            int indexData = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (LetterToIndex.ContainsKey(char.ToLower(str[i])))
                {
                    char kChar = fullKey[keyPointer];
                    while (!LetterToIndex.ContainsKey(kChar))
                    {
                        keyPointer++;
                        kChar = fullKey[keyPointer];
                    }
                    long m = LetterToIndex[char.ToLower(str[i])];
                    long k = LetterToIndex[kChar];

                    long cipherIndex = (m + k) % LenOfAlfavit;
                    char cipherChar = IndexToLetter[(int)cipherIndex];

                    shiphroText += cipherChar;

                    textDataGridView.Columns.Add((str[i] + i).ToString(), str[i].ToString());
                    textDataGridView.Rows[0].Cells[indexData].Value = fullKey[keyPointer];
                    textDataGridView.Rows[1].Cells[indexData].Value = shiphroText[^1];

                    keyPointer++;
                    indexData++;
                }
                else if (!char.IsLetter(str[i]))
                {
                    shiphroText += str[i];
                }
            }

            return shiphroText;
        }

        public string DecryptVijenerText(string str, string secretKey)
        {
            textDataGridView.Columns.Add("clearColumn", "Исходный символ");
            textDataGridView.Rows.Add();
            textDataGridView.Rows[0].Cells[0].Value = "Буква ключа";
            textDataGridView.Rows.Add();
            textDataGridView.Rows[1].Cells[0].Value = "Итоговый символ";

            string shiphroText = "";
            int keyPointer = 0;
            int indexData = 1;

            for (int i = 0; i < str.Length; i++)
            {

                if (LetterToIndex.ContainsKey(char.ToLower(str[i])))
                {
                    char kChar = (keyPointer < secretKey.Length)
                                 ? char.ToLower(secretKey[keyPointer])
                                 : char.ToLower(shiphroText[keyPointer - secretKey.Length]);
                    while (!LetterToIndex.ContainsKey(kChar))
                    {
                        keyPointer++;
                        kChar = (keyPointer < secretKey.Length)
                                 ? char.ToLower(secretKey[keyPointer])
                                 : char.ToLower(shiphroText[keyPointer - secretKey.Length]);
                    }

                    long m = LetterToIndex[char.ToLower(str[i])];
                    long k = LetterToIndex[kChar];

                    long cipherIndex = (m - k + LenOfAlfavit) % LenOfAlfavit;
                    char cipherChar = IndexToLetter[(int)cipherIndex];

                    shiphroText += cipherChar;

                    textDataGridView.Columns.Add((str[i] + i).ToString(), str[i].ToString());
                    textDataGridView.Rows[0].Cells[indexData].Value = kChar;
                    textDataGridView.Rows[1].Cells[indexData].Value = shiphroText[^1];

                    keyPointer++;
                    indexData++;
                }
                else if (!char.IsLetter(str[i]))
                {
                    shiphroText += str[i];
                }
            }
            return shiphroText;
        }

        public Form1()
        {
            InitializeComponent();
            shipherFunctionComboBox.SelectedIndex = shipherMetodComboBox.SelectedIndex = 0;
            openFileDialog1.Multiselect = false;
            saveFileDialog1.Filter = openFileDialog1.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
        }

        private void ShipherTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedShipherType = (ShipherType)shipherMetodComboBox.SelectedIndex;
            StartProcessing();
        }

        private void shipherFunctionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedShipherFunction = (ShipherFunction)shipherFunctionComboBox.SelectedIndex;
            StartProcessing();
        }

        #region Работа с файлами
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "ShiphredText.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream file = new(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    using (StreamWriter wr = new(file))
                    {
                        wr.Write(finalTextBox.Text?.Length > 0 ? finalTextBox.Text : " ");
                    }
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream file = new(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader wr = new(file))
                    {
                        startTextBox.Text = wr.ReadToEnd();
                    }
                }
            }
        }
        #endregion


        private void startTextBox_TextChanged(object sender, EventArgs e)
        {
            StartProcessing();
        }
        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {
            StartProcessing();
        }

        private void StartProcessing()
        {
            textDataGridView.Columns.Clear();
            textDataGridView.Rows.Clear();
            if (keyTextBox.Text?.Length > 0 && startTextBox.Text?.Length > 0)
            {
                switch (SelectedShipherType)
                {
                    case ShipherType.Decimazii:
                        long dkey;
                        string normalKey = "";
                        for (int i = 0; i < keyTextBox.Text.Length; i++)
                        {
                            if (char.IsDigit(keyTextBox.Text[i]))
                            {
                                normalKey += keyTextBox.Text[i];
                            }
                        }
                        if (long.TryParse(normalKey, out dkey))
                        {
                            errorKeyLabel.Text = "";
                            if (!CheckDezimaziiKey(dkey))
                            {
                                errorKeyLabel.Text = "Ключ взаимно не простой"; return;
                            }
                        }
                        else
                        {
                            errorKeyLabel.Text = "Недопустимая длина ключа";
                        }

                        switch (SelectedShipherFunction)
                        {
                            case ShipherFunction.Shipher:
                                finalTextBox.Text = EncryptDezimaziiText(startTextBox.Text, dkey);
                                break;
                            case ShipherFunction.DeShipher:
                                finalTextBox.Text = DecryptDezimaziiText(startTextBox.Text, dkey);
                                break;
                        }

                        break;
                    case ShipherType.Vijener:
                        normalKey = "";
                        for (int i = 0; i < keyTextBox.Text.Length; i++)
                        {
                            if (LetterToIndex.ContainsKey(char.ToLower(keyTextBox.Text[i])))
                            {
                                normalKey += keyTextBox.Text[i];
                            }
                        }
                        if (normalKey?.Length <= 0)
                        {
                            errorKeyLabel.Text = "Ключ пустой"; return;
                        }

                        switch (SelectedShipherFunction)
                        {
                            case ShipherFunction.Shipher:
                                finalTextBox.Text = EncryptVijenerText(startTextBox.Text, normalKey);
                                break;
                            case ShipherFunction.DeShipher:
                                finalTextBox.Text = DecryptVijenerText(startTextBox.Text, normalKey);
                                break;
                        }
                        break;
                }


            }
        }

        private void textDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
