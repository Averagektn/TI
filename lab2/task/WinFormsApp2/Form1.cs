using System.IO;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string SourceFilePath = string.Empty;
        string DestFilePath = string.Empty;

        private void Process(ref string cipher, ref string key)
        {
            if (!File.Exists(SourceFilePath))
            {
                MessageBox.Show("File not found");
                return;
            }
            if (tbRegister.Text.Length != tbRegister.MaxLength)
            {
                MessageBox.Show("Register in not filled");
                return;
            }

            cipher = string.Empty;
            key = string.Empty;

            string extension = Path.GetExtension(SourceFilePath);
            saveFileDialog.Filter = $"Files (*{extension})|*{extension}";
            saveFileDialog.FileName = string.Empty;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DestFilePath = saveFileDialog.FileName;

                string binaryString = "0" + tbRegister.Text;
                byte[] register = new byte[4];

                for (int i = 0; i < 4; i++)
                {
                    register[^(i + 1)] = Convert.ToByte(binaryString.Substring(i * 8, 8), 2);
                }
                string[] output = StreamCipher.Cipher(new int[] { 3, 31 }, register, SourceFilePath, DestFilePath);

                key = output[0];
                cipher = output[1];

                DestFilePath = string.Empty;
                SourceFilePath = string.Empty;
            }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            string cipher = tbCipher.Text;
            string key = tbKey.Text;

            Process(ref cipher, ref key);

            tbCipher.Text = cipher;
            tbKey.Text = key;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            string cipher = tbMessage.Text;
            string key = tbKey.Text;

            Process(ref cipher, ref key);

            tbMessage.Text = cipher;
            tbKey.Text = key;
        }

        private string Loading()
        {
            string message = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SourceFilePath = openFileDialog.FileName;

                int count = 128;
                byte[] buffer = new byte[count];

                using FileStream stream = File.OpenRead(SourceFilePath);
                int bytesRead = stream.Read(buffer, 0, count);

                for (int i = 0; i < bytesRead; i++)
                {
                    message += (Convert.ToString(buffer[i], 2).PadLeft(8, '0') + " ");
                }
            }
            return message;
        }

        private void LoadSourceFile_Click(object sender, EventArgs e)
        {
            tbMessage.Text = Loading();
        }

        private void LoadEncryptedFile_Click(object sender, EventArgs e)
        {
            tbCipher.Text = Loading();
        }

        private void Register_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '1' && e.KeyChar != '0' && e.KeyChar != 8)
            {
                e.Handled = true; 
            }
        }
    }
}