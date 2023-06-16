using System.Numerics;
//618970019642690137449562111
namespace lab3
{
    public partial class MainForm : Form
    {
        private const int OUTPUT_BYTES = 100;

        private string src = string.Empty, dst = string.Empty;
        private BigInteger p, x, k, g;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            bool isFullData = true;
            if (lbG.SelectedItem == null)
            {
                MessageBox.Show("G is not selected");
                isFullData = false;
            }
            if (tbK.Text == string.Empty)
            {
                MessageBox.Show("K is not filled");
                isFullData = false;
            }
            if (tbP.Text == string.Empty)
            {
                MessageBox.Show("P is not filled");
                isFullData = false;
            }
            if (tbX.Text == string.Empty)
            {
                MessageBox.Show("X is not filled");
                isFullData = false;
            }
            if (src == string.Empty)
            {
                MessageBox.Show("Source file is not selected");
                isFullData = false;
            }

            string extension = Path.GetExtension(src);
            saveFileDialog.Filter = $"Files (*{extension})|*{extension}";
            saveFileDialog.FileName = string.Empty;

            if (isFullData && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dst = saveFileDialog.FileName;

                tbCipher.Text = string.Empty;
                tbMessage.Text = string.Empty;

                p = BigInteger.Parse(tbP.Text);
                x = BigInteger.Parse(tbX.Text);
                k = BigInteger.Parse(tbK.Text);
                g = BigInteger.Parse(lbG.SelectedItem!.ToString()!);

                ElGamal.Encrypt(p, x, k, g, src, dst);

                ShowFileBytes(src, dst);
                src = string.Empty;
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            bool isFullData = true;
            if (tbP.Text == string.Empty)
            {
                MessageBox.Show("P is not filled");
                isFullData = false;
            }
            if (tbX.Text == string.Empty)
            {
                MessageBox.Show("X is not filled");
                isFullData = false;
            }
            if (src == string.Empty)
            {
                MessageBox.Show("Source file is not selected");
                isFullData = false;
            }

            string extension = Path.GetExtension(src);
            saveFileDialog.Filter = $"Files (*{extension})|*{extension}";
            saveFileDialog.FileName = string.Empty;

            if (isFullData && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dst = saveFileDialog.FileName;
                p = BigInteger.Parse(tbP.Text);
                x = BigInteger.Parse(tbX.Text);

                ElGamal.Decrypt(p, x, src, dst);

                ShowFileBytes(dst, src);
                src = string.Empty;
            }
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                src = openFileDialog.FileName;
            }
        }

        private void P_Leave(object sender, EventArgs e)
        {
            if (tbP.Text.Length > 0)
            {
                var num = BigInteger.Parse(tbP.Text);
                if (BigInteger.Compare(num, 255) > 0)
                {
                    if (MyCoolMath.IsPrime(num))
                    {
                        int i = 0;
                        lbG.Items.Clear();
                        List<BigInteger> primitives = MyCoolMath.Primitives(num);
                        foreach (BigInteger element in primitives)
                        {
                            i++;
                            lbG.Items.Add(element.ToString());
                        }
                        Text = i.ToString();

                        p = num;
                    }
                    else
                    {
                        MessageBox.Show("p = " + tbP.Text + " is not prime");
                        tbP.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("p shold be more than 255");
                    tbP.Text = string.Empty;
                }
            }
        }

        private void P_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbP.Text.Length > 0)
            {
                tbX.Enabled = true;
                tbK.Enabled = true;
            }
            else
            {
                tbX.Enabled = false;
                tbK.Enabled = false;
            }
        }

        private void X_Leave(object sender, EventArgs e)
        {
            if (tbX.Text.Length > 0)
            {
                BigInteger num = BigInteger.Parse(tbX.Text);
                if (num <= BigInteger.One || BigInteger.Compare(num, p - 1) >= 0)
                {
                    MessageBox.Show($"x = {tbX.Text} is not in 1 < x < {tbP.Text} - 1");
                    tbX.Text = string.Empty;
                }
            }
        }

        private void K_Leave(object sender, EventArgs e)
        {
            if (tbK.Text.Length > 0)
            {
                BigInteger num = BigInteger.Parse(tbK.Text);
                if (num > BigInteger.One && BigInteger.Compare(num, p - 1) < 0)
                {
                    if (MyCoolMath.EuclideanExt(num, p - 1)[0] != 1)
                    {
                        MessageBox.Show($"k = {tbK.Text} is not coprime with p - 1 = {tbP.Text} - 1");
                        tbK.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show($"For k = {tbK.Text}, k <= 1 or k >= {tbP.Text} - 1");
                    tbK.Text = string.Empty;
                }
            }
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE)
            {
                e.Handled = true;
            }
        }

        private void ShowFileBytes(string message, string cipher)
        {
            tbCipher.Text = string.Empty;
            tbMessage.Text = string.Empty;

            var sizeofBlock = p.GetByteCount();

            byte[] bytesCipher, bytesMessage;
            var file = new FileInfo(message);
            if (file.Length < OUTPUT_BYTES)
            {
                bytesMessage = new byte[file.Length];
                bytesCipher = new byte[file.Length * sizeofBlock * 2];
            }
            else
            {
                bytesMessage = new byte[OUTPUT_BYTES];
                bytesCipher = new byte[OUTPUT_BYTES * sizeofBlock * 2];
            }

            using var fileRead_src = new FileStream(message, FileMode.Open, FileAccess.Read);
            fileRead_src.Read(bytesMessage, 0, bytesMessage.Length);
            for (int i = 0; i < bytesMessage.Length; i++)
            {
                tbMessage.Text += bytesMessage[i] + " ";
            }

            using var fileRead_dst = new FileStream(cipher, FileMode.Open, FileAccess.Read);
            fileRead_dst.Read(bytesCipher, 0, bytesCipher.Length);
            for (int i = 0; i < bytesCipher.Length; i += sizeofBlock * 2)
            {
                var output = new byte[sizeofBlock];
                BigInteger value = BigInteger.Zero;
                for (int j = sizeofBlock - 1; j >= 0; j--)
                {
                    if (i + j < bytesCipher.Length)
                    {
                        value = BigInteger.RotateLeft(value, 8);
                        value = BigInteger.Add(value, bytesCipher[i + j]);
                        output[j] = bytesCipher[i + j];
                    }
                }

                tbCipher.Text += value.ToString() + "|";

/*                for (int k = output.Length - 1; k >= 0; k--)
                {
                    tbCipher.Text += output[k].ToString() + " ";
                }
                tbCipher.Text += "| ";*/

                value = BigInteger.Zero;
                for (int j = sizeofBlock * 2 - 1; j >= sizeofBlock; j--)
                {
                    if (i + j < bytesCipher.Length)
                    {
                        value = BigInteger.RotateLeft(value, 8);
                        value = BigInteger.Add(value, bytesCipher[i + j]);
                        output[j - sizeofBlock] = bytesCipher[i + j];
                    }
                }

/*                for (int k = output.Length - 1; k >= 0; k--)
                {
                    tbCipher.Text += output[k].ToString() + " ";
                }
                tbCipher.Text += "* ";*/

                tbCipher.Text += value.ToString() + " ";


            }

            if (file.Length >= OUTPUT_BYTES * 2)
            {
                tbMessage.Text += "\r\n\r\n\r\n";
                using var fileRead_src_end = new FileStream(message, FileMode.Open, FileAccess.Read);
                fileRead_src_end.Seek(-OUTPUT_BYTES, SeekOrigin.End);
                fileRead_src_end.Read(bytesMessage, 0, bytesMessage.Length);
                for (int i = 0; i < bytesMessage.Length; i++)
                {
                    tbMessage.Text += bytesMessage[i] + " ";
                }

                tbCipher.Text += "\r\n\r\n\r\n";

                using var fileStream = new FileStream(cipher, FileMode.Open, FileAccess.Read);
                fileStream.Seek(-OUTPUT_BYTES * 2 * sizeofBlock, SeekOrigin.End);
                fileStream.Read(bytesCipher, 0, bytesCipher.Length);
                for (int i = 0; i < bytesCipher.Length; i += sizeofBlock * 2)
                {
                    var output = new byte[sizeofBlock];
                    BigInteger value = BigInteger.Zero;
                    for (int j = sizeofBlock - 1; j >= 0; j--)
                    {
                        if (i + j < bytesCipher.Length)
                        {
                            value = BigInteger.RotateLeft(value, 8);
                            value = BigInteger.Add(value, bytesCipher[i + j]);
                            output[j] = bytesCipher[i + j];
                        }
                    }

                    tbCipher.Text += value.ToString() + "|";

/*                    for (int k = output.Length - 1; k >= 0; k--)
                    {
                        tbCipher.Text += output[k].ToString() + " ";
                    }
                    tbCipher.Text += "| ";*/

                    value = BigInteger.Zero;
                    for (int j = sizeofBlock * 2 - 1; j >= sizeofBlock; j--)
                    {
                        if (i + j < bytesCipher.Length)
                        {
                            value = BigInteger.RotateLeft(value, 8);
                            value = BigInteger.Add(value, bytesCipher[i + j]);
                            output[j - sizeofBlock] = bytesCipher[i + j];
                        }
                    }

/*                    for (int k = output.Length - 1; k >= 0; k--)
                    {
                        tbCipher.Text += output[k].ToString() + " ";
                    }
                    tbCipher.Text += "* ";*/

                    tbCipher.Text += value.ToString() + " ";


                }
            }


        }
    }
}
