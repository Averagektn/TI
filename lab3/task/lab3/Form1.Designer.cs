namespace lab3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbCipher = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbK = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lbG = new System.Windows.Forms.ListBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblCipher = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMessage.Location = new System.Drawing.Point(380, 40);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(800, 200);
            this.tbMessage.TabIndex = 0;
            // 
            // tbCipher
            // 
            this.tbCipher.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCipher.Location = new System.Drawing.Point(380, 308);
            this.tbCipher.Multiline = true;
            this.tbCipher.Name = "tbCipher";
            this.tbCipher.ReadOnly = true;
            this.tbCipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCipher.Size = new System.Drawing.Size(800, 200);
            this.tbCipher.TabIndex = 1;
            // 
            // tbP
            // 
            this.tbP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbP.Location = new System.Drawing.Point(12, 40);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(129, 32);
            this.tbP.TabIndex = 2;
            this.tbP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.tbP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.P_KeyUp);
            this.tbP.Leave += new System.EventHandler(this.P_Leave);
            // 
            // tbK
            // 
            this.tbK.Enabled = false;
            this.tbK.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbK.Location = new System.Drawing.Point(12, 313);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(129, 32);
            this.tbK.TabIndex = 3;
            this.tbK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.tbK.Leave += new System.EventHandler(this.K_Leave);
            // 
            // tbX
            // 
            this.tbX.Enabled = false;
            this.tbX.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbX.Location = new System.Drawing.Point(12, 181);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(129, 32);
            this.tbX.TabIndex = 4;
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.tbX.Leave += new System.EventHandler(this.X_Leave);
            // 
            // lbG
            // 
            this.lbG.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbG.FormattingEnabled = true;
            this.lbG.ItemHeight = 25;
            this.lbG.Location = new System.Drawing.Point(157, 40);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(190, 529);
            this.lbG.TabIndex = 5;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.Location = new System.Drawing.Point(380, 519);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(200, 50);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt...";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseFile.Location = new System.Drawing.Point(663, 519);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(200, 50);
            this.btnChooseFile.TabIndex = 7;
            this.btnChooseFile.Text = "Choose file...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecrypt.Location = new System.Drawing.Point(934, 519);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(200, 50);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Decrypt...";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(380, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(86, 25);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Message";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblX.Location = new System.Drawing.Point(62, 153);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 25);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "X";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblP.Location = new System.Drawing.Point(62, 12);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(23, 25);
            this.lblP.TabIndex = 11;
            this.lblP.Text = "P";
            // 
            // lblCipher
            // 
            this.lblCipher.AutoSize = true;
            this.lblCipher.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCipher.Location = new System.Drawing.Point(380, 280);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(68, 25);
            this.lblCipher.TabIndex = 12;
            this.lblCipher.Text = "Cipher";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblG.Location = new System.Drawing.Point(233, 12);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(25, 25);
            this.lblG.TabIndex = 13;
            this.lblG.Text = "G";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblK.Location = new System.Drawing.Point(62, 280);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(23, 25);
            this.lblK.TabIndex = 14;
            this.lblK.Text = "K";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 579);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblCipher);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lbG);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbCipher);
            this.Controls.Add(this.tbMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "El Gamal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbMessage;
        private TextBox tbCipher;
        private TextBox tbP;
        private TextBox tbK;
        private TextBox tbX;
        private ListBox lbG;
        private Button btnEncrypt;
        private Button btnChooseFile;
        private Button btnDecrypt;
        private Label lblMessage;
        private Label lblX;
        private Label lblP;
        private Label lblCipher;
        private Label lblG;
        private Label lblK;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}