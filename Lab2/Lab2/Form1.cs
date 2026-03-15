using System.Text;

namespace Lab2
{
    public partial class Form1 : Form
    {
        //вариант 7, степень 29

        private byte[] _fileBytes;
        private byte[] _resultBytes;
        private const int Degree = 29;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Multiselect = false;
            saveFileDialog1.Filter = openFileDialog1.Filter = "Все файлы|*.*";

        }

        #region работа с файлами
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (_resultBytes == null)
            {
                MessageBox.Show("Нет данных для сохранения.");
                return;
            }
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, _resultBytes);
                MessageBox.Show("Файл успешно сохранен.");
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _fileBytes = File.ReadAllBytes(openFileDialog1.FileName);
                startListBox.Items.Clear();
                foreach (byte b in _fileBytes)
                {
                    startListBox.Items.Add(Convert.ToString(b, 2).PadLeft(8, '0'));
                    finalListBox.Text = "";
                    keyListBox.Text = "";
                }
            }
        }
        #endregion

        private void ProcessEncryption()
        {
            if (_fileBytes == null)
            {
                MessageBox.Show("Сначала выберите файл!");
                return;
            }

            string seedStr = "";
            for (int i = 0; i < startRegisterTextBox.Text.Length; i++)
            {
                if (startRegisterTextBox.Text[i] == '0' || startRegisterTextBox.Text[i] == '1')
                {
                    seedStr += startRegisterTextBox.Text[i];
                }
            }
            if (seedStr.Length < Degree)
            {
                MessageBox.Show($"Введите начальное состояние (минимум {Degree} бит)!");
                return;
            }

            uint register = 0;
            for (int i = 0; i < Degree; i++)
            {
                if (seedStr[i] == '1')
                    register |= (1u << (Degree - 1 - i));
            }

            _resultBytes = new byte[_fileBytes.Length];
            keyListBox.Clear();
            finalListBox.Items.Clear();

            StringBuilder keyVisualizer = new StringBuilder();

            for (int i = 0; i < _fileBytes.Length; i++)
            {
                byte keyByte = 0;

                for (int bit = 0; bit < 8; bit++)
                {
                    uint Ki = register & 1;
                    keyByte = (byte)((keyByte << 1) | Ki);
                    uint fb = ((register >> 28) ^ (register >> 1)) & 1;
                    register = (register >> 1) | (fb << 28); 

                    keyVisualizer.Append(Ki+'\n');
                }

                _resultBytes[i] = (byte)(_fileBytes[i] ^ keyByte);

                finalListBox.Items.Add(Convert.ToString(_resultBytes[i], 2).PadLeft(8, '0'));
            }
            keyListBox.Text = (keyVisualizer.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessEncryption();
        }
    }
}
