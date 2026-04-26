using System.Runtime.InteropServices;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private byte[] _fileBytes;
        private byte[] _resultbyte;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Multiselect = false;
            saveFileDialog1.Filter = openFileDialog1.Filter = "Все файлы|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _fileBytes = File.ReadAllBytes(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_resultbyte == null)
            {
                MessageBox.Show("Нет данных для сохранения.");
                return;
            }
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, _resultbyte);
                MessageBox.Show("Файл успешно сохранен.");
            }
        }

        bool CheckNumSimple(int num)
        {
            if (num <= 1) return false;
            if (num <= 3) return true;
            if (num % 2 == 0 || num % 3 == 0) return false;

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        bool CheckNumsChipher(ref int p, ref int q, ref int k)
        {
            if (!int.TryParse(pTextBox.Text, out p))
            {
                MessageBox.Show("p не число");
                return false;
            }
            if (!CheckNumSimple(p))
            {
                MessageBox.Show("p не простое");
                return false;
            }
            if (!int.TryParse(qTextBox.Text, out q))
            {
                MessageBox.Show("q не число");
                return false;
            }
            if (!CheckNumSimple(p))
            {
                MessageBox.Show("q не простое");
                return false;
            }
            if (p==q)
            {
                MessageBox.Show("q и p должны быть разными");
                return false;
            }
            if (!int.TryParse(kTextBox.Text, out k))
            {
                MessageBox.Show("Kc не число");
                return false;
            }
            return true;
        }

        bool CheckNumsDeChipher(ref int r, ref int k)
        {
            if (!int.TryParse(rTextBox.Text, out r))
            {
                MessageBox.Show("r не число");
                return false;
            }
            if (!int.TryParse(kTextBox.Text, out k))
            {
                MessageBox.Show("Kc не число");
                return false;
            }
            return true;
        }

        public static int EvclidEx(int d, int fr)
        {
            int m0 = fr, t, q;
            int x0 = 0, x1 = 1;

            if (fr == 1) return 0;

            while (d > 1)
            {
                if (fr == 0) break;
                q = d / fr;
                t = fr;
                fr = d % fr;
                d = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (d != 1) return -1;

            if (x1 < 0) x1 += m0;
            return x1;
        }

        public int FastPower(int a, int b, int n)
        {
            long res = 1;
            long baseNum = a % n;
            while (b > 0)
            {
                if (b % 2 == 1) res = (res * baseNum) % n;
                baseNum = (baseNum * baseNum) % n;
                b /= 2;
            }
            return (int)res;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_fileBytes != null)
            {
                int p = 0, q = 0, k = 0, r = 0, fr = 0, Ke = 0;
                if (pTextBox.Text?.Length > 0 && qTextBox.Text?.Length > 0 && kTextBox.Text?.Length > 0)
                {
                    if (CheckNumsChipher(ref p, ref q, ref k))
                    {
                        r = p * q;
                        fr = (p - 1) * (q - 1);
                        rTextBox.Text = r.ToString();
                        if (r < 256 || r > 65_536)
                        {
                            MessageBox.Show("p и q дают в произведении число меньше байта или больше двух");
                            return;
                        }
                        if (k <= 1 || k > fr)
                        {
                            MessageBox.Show("Kc не корректное число");
                            return;
                        }

                        Ke = EvclidEx(k, fr);
                        if (Ke != -1)
                        {
                            MessageBox.Show($"Открытый ключ: {Ke}");

                            ushort[] encryptedData = new ushort[_fileBytes.Length];
                            System.Text.StringBuilder sb = new System.Text.StringBuilder();

                            for (int i = 0; i < _fileBytes.Length; i++)
                            {
                                encryptedData[i] = (ushort)FastPower(_fileBytes[i], Ke, r);
                                sb.Append(encryptedData[i].ToString() + " ");
                            }

                            richTextBox1.Text = sb.ToString();
                            _resultbyte = MemoryMarshal.AsBytes(encryptedData.AsSpan()).ToArray();

                            MessageBox.Show("Шифрование завершено");
                        }
                        else
                        {
                            MessageBox.Show("KC и f(r) не взаимно простые. Выберите другое Kc");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите p, q и Kc");
                }
            }
            else
            {
                MessageBox.Show("Не выбран файл");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_fileBytes != null)
            {
                int r = 0, k = 0;
                if (rTextBox.Text?.Length > 0 && kTextBox.Text?.Length > 0)
                {
                    if (CheckNumsDeChipher(ref r, ref k))
                    {
                        try
                        {
                            ReadOnlySpan<ushort> encryptedData = MemoryMarshal.Cast<byte, ushort>(_fileBytes);

                            byte[] decryptedBytes = new byte[encryptedData.Length];
                            richTextBox1.Clear();
                            System.Text.StringBuilder sb = new System.Text.StringBuilder();

                            for (int i = 0; i < encryptedData.Length; i++)
                            {
                                // Расшифровка M = C^k mod r
                                decryptedBytes[i] = (byte)FastPower(encryptedData[i], k, r);

                                sb.Append(decryptedBytes[i] + " ");
                            }

                            richTextBox1.Text = sb.ToString();
                            _resultbyte = decryptedBytes;

                            MessageBox.Show("Расшифрование завершено успешно!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка: проверьте ключи или целостность файла.");
                        }
                    }
                }
                else MessageBox.Show("Введите r и Kc");
            }
            else MessageBox.Show("Не выбран файл");
        }
    }
}
