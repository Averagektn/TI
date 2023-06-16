using System.CodeDom;
using System.Text.RegularExpressions;
using System.Web;

namespace Railroad
{
    public partial class Form1 : Form
    {
        const string FILTER = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        const string RAIL_ENCRYPT_ERROR = "To use this method of encryption, enter any number greater then 1 as a key";
        const string VIGENERE_ENCRYPT_ERROR = "To use this method of encryption, enter any word with cyrillic letters as a key";
        const string RAIL_DECRYPT_ERROR = "To use this method of decryption, enter any number greater then 1 as a key";
        const string VIGENERE_DECRYPT_ERROR = "To use this method of encryption, enter any word with cyrillic letters as a key";

        public Form1()
        {
            InitializeComponent();
            openFileDialog.Filter = FILTER;
            saveFileDialog.Filter = FILTER;
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            string line = string.Empty, vigenereKey = string.Empty;
            int railroadKey = 0;
            tbCipher.Clear();

            if (rbRailroad.Checked)
            {
                string tmp = Regex.Replace(tbKey.Text, @"[^0-9]", "");
                if (tmp != string.Empty)
                {
                    railroadKey = Convert.ToInt32(tmp);
                }
                line = Railroad.Encrypt(tbMessage.Text, railroadKey);
            }
            else if (rbVigenere.Checked)
            {
                vigenereKey = tbKey.Text.ToUpper();
                vigenereKey = Regex.Replace(vigenereKey, @"[^À-ß¨]", "");
                line = Vigenere.Encrypt(tbMessage.Text, vigenereKey);
            }
            tbCipher.AppendText(line);
            if (rbRailroad.Checked && railroadKey == 0)
            {
                MessageBox.Show(RAIL_ENCRYPT_ERROR);
            }
            if (rbVigenere.Checked && vigenereKey == string.Empty)
            {
                MessageBox.Show(VIGENERE_ENCRYPT_ERROR);
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            string vigenereKey = string.Empty;
            int railroadKey = 0;
            tbMessage.Clear();

            string line;
            if (rbRailroad.Checked)
            {
                string tmp = Regex.Replace(tbKey.Text, @"[^0-9]", "");
                if (tmp != string.Empty)
                {
                    railroadKey = Convert.ToInt32(tmp);
                }
                line = Railroad.Decrypt(tbCipher.Text, railroadKey);
            }
            else
            {
                vigenereKey = tbKey.Text.ToUpper();
                vigenereKey = Regex.Replace(vigenereKey, @"[^À-ß¨]", "");
                line = Vigenere.Decrypt(tbCipher.Text, vigenereKey);
            }
            tbMessage.AppendText(line + Environment.NewLine);

            if (rbRailroad.Checked && railroadKey == 0)
            {
                MessageBox.Show(RAIL_DECRYPT_ERROR);
            }
            if (rbVigenere.Checked && vigenereKey == string.Empty)
            {
                MessageBox.Show(VIGENERE_DECRYPT_ERROR);
            }
        }

        private void LoadMessage_Click(object sender, EventArgs e)
        {
            tbMessage.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                tbMessage.Text = File.ReadAllText(filename);
            }
        }

        private void LoadCipher_Click(object sender, EventArgs e)
        {
            tbCipher.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                tbCipher.Text = File.ReadAllText(filename);
            }
        }

        private void LoadKey_Click(object sender, EventArgs e)
        {
            tbKey.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                tbKey.Text = File.ReadAllText(filename);
            }
        }

        private void SaveCipher_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                File.Create(filename).Close();
                File.WriteAllText(filename, tbCipher.Text);
            }
        }

        private void SaveMessage_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                File.Create(filename).Close();
                File.WriteAllText(filename, tbMessage.Text);
            }
        }

        private void Decrypt_KeyDown(object sender, KeyEventArgs e)
        {
            tbMessage.Clear();
        }

        private void Encrypt_KeyDown(object sender, KeyEventArgs e)
        {
            tbCipher.Clear();
        }

        private void TextChangedHandle(string src, Button btn)
        {
            if (src == string.Empty)
            {
                btn.Enabled = false;
            }
            else
            {
                btn.Enabled = true;
            }
        }

        private void Decrypt_TextChanged(object sender, EventArgs e)
        {
            TextChangedHandle(tbCipher.Text, btnDecrypt);
        }

        private void Encrypt_TextChanged(object sender, EventArgs e)
        {
            TextChangedHandle(tbMessage.Text, btnEncrypt);
        }
    }
}