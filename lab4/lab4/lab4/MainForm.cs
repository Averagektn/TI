using System.Numerics;

namespace lab4
{
    public partial class MainForm : Form
    {
        private string srcFile = string.Empty, signatureFile = string.Empty;

        Object obj = null;
        public MainForm()
        {
            Console.WriteLine(obj.ToString());
            InitializeComponent();
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            BigInteger q, p, x, k, h;

            tbReceivedHash.Clear();
            tbReceivedSignature.Clear();
            tbCalculatedHash.Clear();
            tbCalculatedSignature.Clear();

            if (tbQ.Text.Length == 0)
            {
                isValid = false;
            }
            if (tbP.Text.Length == 0)
            {
                isValid = false;
            }
            if (tbX.Text.Length == 0)
            {
                isValid = false;
            }
            if (tbK.Text.Length == 0)
            {
                isValid = false;
            }
            if (tbH.Text.Length == 0)
            {
                isValid = false;
            }
            if (srcFile == string.Empty)
            {
                isValid = false;
            }
            if (isValid)
            {
                q = BigInteger.Parse(tbQ.Text);
                p = BigInteger.Parse(tbP.Text);
                x = BigInteger.Parse(tbX.Text);
                k = BigInteger.Parse(tbK.Text);
                h = BigInteger.Parse(tbH.Text);

                BigInteger g = MyCoolMath.ModPow(h, BigInteger.Divide(p - 1, q), p);
                if (g > 1)
                {
                    if (MyCoolSignature.Sign(p, q, x, k, g, srcFile, out BigInteger r, out BigInteger s, out BigInteger hash))
                    {
                        MessageBox.Show("Signed");

                        tbCalculatedHash.Text = hash.ToString();
                        tbCalculatedSignature.Text = "r: " + r.ToString() + " s: " + s.ToString();

                        string textSignatureFileName = Path.Combine("signatures", Path.GetFileNameWithoutExtension(srcFile) + "_TEXT.txt");
                        using var sw = new StreamWriter(textSignatureFileName, false);
                        sw.Write(tbCalculatedSignature.Text);
                    }
                    else
                    {
                        MessageBox.Show("Signing error, r = 0 or s = 0");
                    }
                }
                else
                {
                    MessageBox.Show("G <= 1");
                }
            }
            else
            {
                MessageBox.Show("Fields are not filled or file is not selected");
            }
            signatureFile = string.Empty;
            srcFile = string.Empty;
        }

        private void Verify_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            BigInteger q, p, h;

            if (tbQ.Text.Length == 0)
            {
                isValid = false;
            }
            if (tbP.Text.Length == 0)
            {
                isValid = false;
            }
            if (tbH.Text.Length == 0)
            {
                isValid = false;
            }
            if (srcFile  == string.Empty)
            {
                isValid = false;
            }

            if (signatureFile == string.Empty)
            {
                signatureFile = Path.Combine("signatures", Path.GetFileNameWithoutExtension(srcFile) + "_SIGNATURE.txt");
                if (!File.Exists(signatureFile))
                {
                    isValid = false;
                }
            }

            if (isValid)
            {
                p = BigInteger.Parse(tbP.Text);
                q = BigInteger.Parse(tbQ.Text);
                h = BigInteger.Parse(tbH.Text);

                BigInteger g = MyCoolMath.ModPow(h, BigInteger.Divide(p - 1, q), p);
                if (g > 1)
                {
                    if (MyCoolSignature.CheckSignature(p, q, g, srcFile, signatureFile, out CheckSign result))
                    {   
                        MessageBox.Show("Confirmed");
                    }
                    else
                    {
                        MessageBox.Show("Rejected");
                    }
                    tbCalculatedHash.Text = result.hash.ToString();
                    tbReceivedSignature.Text = "r: " + result.r.ToString() + " s: " + result.s.ToString();
                    tbCalculatedSignature.Text = "v: " + result.v.ToString() + " u1: " + result.u1 + " u2: " + result.u2 + " w: " + result.w;
                }
                else
                {
                    MessageBox.Show("G <= 1");
                }
            }
            else
            {
                MessageBox.Show("Fields are not filled or file is not selected");
            }
            signatureFile = string.Empty;
            srcFile = string.Empty;
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                srcFile = openFileDialog.FileName;
            }
        }

        private void ChooseSignature_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                signatureFile = openFileDialog.FileName;
            }
        }

        private void Q_Leave(object sender, EventArgs e)
        {
            if (tbQ.Text.Length > 0)
            {
                var q = BigInteger.Parse(tbQ.Text);
                if (!MyCoolMath.IsPrime(q))
                {
                    tbQ.Text = string.Empty;
                    MessageBox.Show("Q is not prime");
                }
                else
                {
                    tbP.Enabled = true;
                    tbX.Enabled = true;
                    tbK.Enabled = true;
                }
            }

        }

        private void P_Leave(object sender, EventArgs e)
        {
            if (tbP.Text.Length > 0)
            {
                var q = BigInteger.Parse(tbQ.Text);
                var p = BigInteger.Parse(tbP.Text);
                if (BigInteger.Remainder(p - 1, q) != 0 || p <= q)
                {
                    MessageBox.Show("p % q != 0 or p <= q");
                    tbP.Text = string.Empty;
                }
                else
                {
                    tbH.Enabled = true;
                }
            }

        }

        private void H_Leave(object sender, EventArgs e)
        {
            if (tbH.Text.Length > 0)
            {
                var p = BigInteger.Parse(tbP.Text);
                var h = BigInteger.Parse(tbH.Text);
                if (h >= p - 1 || h <= 1)
                {
                    MessageBox.Show("h >= p - 1 or h <= 1");
                    tbH.Text = string.Empty;
                }
            }

        }

        private void X_Leave(object sender, EventArgs e)
        {
            if (tbX.Text.Length > 0)
            {
                var q = BigInteger.Parse(tbQ.Text);
                var x = BigInteger.Parse(tbX.Text);
                if (x >= q || x <= 0)
                {
                    MessageBox.Show("x >= q or x <= 0");
                    tbX.Text = string.Empty;
                }
            }
        }

        private void K_Leave(object sender, EventArgs e)
        {
            if (tbK.Text.Length > 0)
            {
                var q = BigInteger.Parse(tbQ.Text);
                var k = BigInteger.Parse(tbK.Text);
                if (k >= q || k <= 0)
                {
                    MessageBox.Show("k >= q or k <= 0");
                    tbK.Text = string.Empty;
                }
            }
        }

        private void Q_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbQ.Text.Length == 0)
            {
                tbP.Text = string.Empty;
                tbX.Text = string.Empty;
                tbK.Text = string.Empty;    
                tbP.Enabled = false;
                tbX.Enabled = false;
                tbK.Enabled = false;
            }
        }

        private void P_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbP.Text.Length == 0)
            {
                tbH.Enabled = false;
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
    }
}