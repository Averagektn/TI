namespace WinFormsApp2
{
    partial class Form1
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbRegister = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbCipher = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnLoadSourceFile = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnLoadEncryptedFile = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblCipher = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // tbRegister
            // 
            this.tbRegister.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRegister.Location = new System.Drawing.Point(343, 29);
            this.tbRegister.MaxLength = 31;
            this.tbRegister.Name = "tbRegister";
            this.tbRegister.Size = new System.Drawing.Size(905, 43);
            this.tbRegister.TabIndex = 0;
            this.tbRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Register_KeyPress);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMessage.Location = new System.Drawing.Point(39, 116);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(400, 300);
            this.tbMessage.TabIndex = 1;
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKey.Location = new System.Drawing.Point(503, 116);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.ReadOnly = true;
            this.tbKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKey.Size = new System.Drawing.Size(400, 300);
            this.tbKey.TabIndex = 2;
            // 
            // tbCipher
            // 
            this.tbCipher.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCipher.Location = new System.Drawing.Point(947, 116);
            this.tbCipher.Multiline = true;
            this.tbCipher.Name = "tbCipher";
            this.tbCipher.ReadOnly = true;
            this.tbCipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCipher.Size = new System.Drawing.Size(400, 300);
            this.tbCipher.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.Location = new System.Drawing.Point(167, 448);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(150, 50);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt...";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // btnLoadSourceFile
            // 
            this.btnLoadSourceFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadSourceFile.Location = new System.Drawing.Point(167, 504);
            this.btnLoadSourceFile.Name = "btnLoadSourceFile";
            this.btnLoadSourceFile.Size = new System.Drawing.Size(150, 50);
            this.btnLoadSourceFile.TabIndex = 5;
            this.btnLoadSourceFile.Text = "Load...";
            this.btnLoadSourceFile.UseVisualStyleBackColor = true;
            this.btnLoadSourceFile.Click += new System.EventHandler(this.LoadSourceFile_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecrypt.Location = new System.Drawing.Point(1086, 448);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(150, 50);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "Decrypt...";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // btnLoadEncryptedFile
            // 
            this.btnLoadEncryptedFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadEncryptedFile.Location = new System.Drawing.Point(1086, 504);
            this.btnLoadEncryptedFile.Name = "btnLoadEncryptedFile";
            this.btnLoadEncryptedFile.Size = new System.Drawing.Size(150, 50);
            this.btnLoadEncryptedFile.TabIndex = 7;
            this.btnLoadEncryptedFile.Text = "Load...";
            this.btnLoadEncryptedFile.UseVisualStyleBackColor = true;
            this.btnLoadEncryptedFile.Click += new System.EventHandler(this.LoadEncryptedFile_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegister.Location = new System.Drawing.Point(258, 29);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(79, 25);
            this.lblRegister.TabIndex = 8;
            this.lblRegister.Text = "Register";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(197, 88);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(70, 25);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Source";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKey.Location = new System.Drawing.Point(670, 88);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(42, 25);
            this.lblKey.TabIndex = 10;
            this.lblKey.Text = "Key";
            // 
            // lblCipher
            // 
            this.lblCipher.AutoSize = true;
            this.lblCipher.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCipher.Location = new System.Drawing.Point(1109, 88);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(68, 25);
            this.lblCipher.TabIndex = 11;
            this.lblCipher.Text = "Cipher";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 584);
            this.Controls.Add(this.lblCipher);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnLoadEncryptedFile);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnLoadSourceFile);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbCipher);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private TextBox tbRegister;
        private TextBox tbMessage;
        private TextBox tbKey;
        private TextBox tbCipher;
        private Button btnEncrypt;
        private Button btnLoadSourceFile;
        private Button btnDecrypt;
        private Button btnLoadEncryptedFile;
        private Label lblRegister;
        private Label lblMessage;
        private Label lblKey;
        private Label lblCipher;
    }
}