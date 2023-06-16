namespace Railroad
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tbCipher = new System.Windows.Forms.TextBox();
            this.btnLoadMessage = new System.Windows.Forms.Button();
            this.btnLoadCipher = new System.Windows.Forms.Button();
            this.rbRailroad = new System.Windows.Forms.RadioButton();
            this.rbVigenere = new System.Windows.Forms.RadioButton();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnSaveCipher = new System.Windows.Forms.Button();
            this.btnSaveMessage = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnLoadKey = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.Location = new System.Drawing.Point(115, 400);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(200, 40);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMessage.Location = new System.Drawing.Point(15, 75);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(400, 250);
            this.tbMessage.TabIndex = 1;
            this.tbMessage.TextChanged += new System.EventHandler(this.Encrypt_TextChanged);
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Encrypt_KeyDown);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(321, 26);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(191, 26);
            this.tbKey.TabIndex = 3;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecrypt.Location = new System.Drawing.Point(525, 400);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(200, 40);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // tbCipher
            // 
            this.tbCipher.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCipher.Location = new System.Drawing.Point(425, 75);
            this.tbCipher.Multiline = true;
            this.tbCipher.Name = "tbCipher";
            this.tbCipher.Size = new System.Drawing.Size(400, 250);
            this.tbCipher.TabIndex = 5;
            this.tbCipher.TextChanged += new System.EventHandler(this.Decrypt_TextChanged);
            this.tbCipher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Decrypt_KeyDown);
            // 
            // btnLoadMessage
            // 
            this.btnLoadMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadMessage.Location = new System.Drawing.Point(165, 365);
            this.btnLoadMessage.Name = "btnLoadMessage";
            this.btnLoadMessage.Size = new System.Drawing.Size(100, 30);
            this.btnLoadMessage.TabIndex = 6;
            this.btnLoadMessage.Text = "Load...";
            this.btnLoadMessage.UseVisualStyleBackColor = true;
            this.btnLoadMessage.Click += new System.EventHandler(this.LoadMessage_Click);
            // 
            // btnLoadCipher
            // 
            this.btnLoadCipher.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadCipher.Location = new System.Drawing.Point(575, 365);
            this.btnLoadCipher.Name = "btnLoadCipher";
            this.btnLoadCipher.Size = new System.Drawing.Size(100, 30);
            this.btnLoadCipher.TabIndex = 7;
            this.btnLoadCipher.Text = "Load...";
            this.btnLoadCipher.UseVisualStyleBackColor = true;
            this.btnLoadCipher.Click += new System.EventHandler(this.LoadCipher_Click);
            // 
            // rbRailroad
            // 
            this.rbRailroad.AutoSize = true;
            this.rbRailroad.Checked = true;
            this.rbRailroad.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbRailroad.Location = new System.Drawing.Point(362, 352);
            this.rbRailroad.Name = "rbRailroad";
            this.rbRailroad.Size = new System.Drawing.Size(151, 29);
            this.rbRailroad.TabIndex = 8;
            this.rbRailroad.TabStop = true;
            this.rbRailroad.Text = "Railroad fence";
            this.rbRailroad.UseVisualStyleBackColor = true;
            // 
            // rbVigenere
            // 
            this.rbVigenere.AutoSize = true;
            this.rbVigenere.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbVigenere.Location = new System.Drawing.Point(362, 387);
            this.rbVigenere.Name = "rbVigenere";
            this.rbVigenere.Size = new System.Drawing.Size(106, 29);
            this.rbVigenere.TabIndex = 9;
            this.rbVigenere.Text = "Vigenere";
            this.rbVigenere.UseVisualStyleBackColor = true;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKey.Location = new System.Drawing.Point(269, 27);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(46, 25);
            this.lblKey.TabIndex = 10;
            this.lblKey.Text = "Key:";
            // 
            // btnSaveCipher
            // 
            this.btnSaveCipher.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCipher.Location = new System.Drawing.Point(575, 330);
            this.btnSaveCipher.Name = "btnSaveCipher";
            this.btnSaveCipher.Size = new System.Drawing.Size(100, 30);
            this.btnSaveCipher.TabIndex = 11;
            this.btnSaveCipher.Text = "Save as...";
            this.btnSaveCipher.UseVisualStyleBackColor = true;
            this.btnSaveCipher.Click += new System.EventHandler(this.SaveCipher_Click);
            // 
            // btnSaveMessage
            // 
            this.btnSaveMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveMessage.Location = new System.Drawing.Point(165, 330);
            this.btnSaveMessage.Name = "btnSaveMessage";
            this.btnSaveMessage.Size = new System.Drawing.Size(100, 30);
            this.btnSaveMessage.TabIndex = 12;
            this.btnSaveMessage.Text = "Save as...";
            this.btnSaveMessage.UseVisualStyleBackColor = true;
            this.btnSaveMessage.Click += new System.EventHandler(this.SaveMessage_Click);
            // 
            // btnLoadKey
            // 
            this.btnLoadKey.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadKey.Location = new System.Drawing.Point(525, 24);
            this.btnLoadKey.Name = "btnLoadKey";
            this.btnLoadKey.Size = new System.Drawing.Size(75, 30);
            this.btnLoadKey.TabIndex = 13;
            this.btnLoadKey.Text = "Load...";
            this.btnLoadKey.UseVisualStyleBackColor = true;
            this.btnLoadKey.Click += new System.EventHandler(this.LoadKey_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(15, 24);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(86, 25);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(757, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cipher";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLoadKey);
            this.Controls.Add(this.btnSaveMessage);
            this.Controls.Add(this.btnSaveCipher);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.rbVigenere);
            this.Controls.Add(this.rbRailroad);
            this.Controls.Add(this.btnLoadCipher);
            this.Controls.Add(this.btnLoadMessage);
            this.Controls.Add(this.tbCipher);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btnEncrypt);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ciphers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog;
        private Button btnEncrypt;
        private TextBox tbMessage;
        private TextBox tbKey;
        private Button btnDecrypt;
        private TextBox tbCipher;
        private Button btnLoadMessage;
        private Button btnLoadCipher;
        private RadioButton rbRailroad;
        private RadioButton rbVigenere;
        private Label lblKey;
        private Button btnSaveCipher;
        private Button btnSaveMessage;
        private SaveFileDialog saveFileDialog;
        private Button btnLoadKey;
        private Label lblMessage;
        private Label label1;
    }
}