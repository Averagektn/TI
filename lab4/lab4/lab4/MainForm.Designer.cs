namespace lab4
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
            this.tbQ = new System.Windows.Forms.TextBox();
            this.tbCalculatedSignature = new System.Windows.Forms.TextBox();
            this.tbReceivedHash = new System.Windows.Forms.TextBox();
            this.tbCalculatedHash = new System.Windows.Forms.TextBox();
            this.tbReceivedSignature = new System.Windows.Forms.TextBox();
            this.tbK = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblCalculatedHash = new System.Windows.Forms.Label();
            this.lblReceivedHash = new System.Windows.Forms.Label();
            this.lblCalculatedSignature = new System.Windows.Forms.Label();
            this.lblReceivedSignature = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnChooseSignature = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(12, 44);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(100, 32);
            this.tbQ.TabIndex = 0;
            this.tbQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.tbQ.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Q_KeyUp);
            this.tbQ.Leave += new System.EventHandler(this.Q_Leave);
            // 
            // tbCalculatedSignature
            // 
            this.tbCalculatedSignature.Location = new System.Drawing.Point(333, 44);
            this.tbCalculatedSignature.Name = "tbCalculatedSignature";
            this.tbCalculatedSignature.ReadOnly = true;
            this.tbCalculatedSignature.Size = new System.Drawing.Size(185, 32);
            this.tbCalculatedSignature.TabIndex = 1;
            // 
            // tbReceivedHash
            // 
            this.tbReceivedHash.Location = new System.Drawing.Point(333, 310);
            this.tbReceivedHash.Multiline = true;
            this.tbReceivedHash.Name = "tbReceivedHash";
            this.tbReceivedHash.ReadOnly = true;
            this.tbReceivedHash.Size = new System.Drawing.Size(185, 32);
            this.tbReceivedHash.TabIndex = 2;
            this.tbReceivedHash.Visible = false;
            // 
            // tbCalculatedHash
            // 
            this.tbCalculatedHash.Location = new System.Drawing.Point(333, 128);
            this.tbCalculatedHash.Multiline = true;
            this.tbCalculatedHash.Name = "tbCalculatedHash";
            this.tbCalculatedHash.ReadOnly = true;
            this.tbCalculatedHash.Size = new System.Drawing.Size(185, 32);
            this.tbCalculatedHash.TabIndex = 3;
            // 
            // tbReceivedSignature
            // 
            this.tbReceivedSignature.Location = new System.Drawing.Point(333, 219);
            this.tbReceivedSignature.Name = "tbReceivedSignature";
            this.tbReceivedSignature.ReadOnly = true;
            this.tbReceivedSignature.Size = new System.Drawing.Size(192, 32);
            this.tbReceivedSignature.TabIndex = 4;
            // 
            // tbK
            // 
            this.tbK.Enabled = false;
            this.tbK.Location = new System.Drawing.Point(12, 416);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(100, 32);
            this.tbK.TabIndex = 5;
            this.tbK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.tbK.Leave += new System.EventHandler(this.K_Leave);
            // 
            // tbX
            // 
            this.tbX.Enabled = false;
            this.tbX.Location = new System.Drawing.Point(12, 310);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 32);
            this.tbX.TabIndex = 6;
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.tbX.Leave += new System.EventHandler(this.X_Leave);
            // 
            // tbP
            // 
            this.tbP.Enabled = false;
            this.tbP.Location = new System.Drawing.Point(12, 128);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(100, 32);
            this.tbP.TabIndex = 7;
            this.tbP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.tbP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.P_KeyUp);
            this.tbP.Leave += new System.EventHandler(this.P_Leave);
            // 
            // tbH
            // 
            this.tbH.Enabled = false;
            this.tbH.Location = new System.Drawing.Point(12, 219);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(100, 32);
            this.tbH.TabIndex = 8;
            this.tbH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.tbH.Leave += new System.EventHandler(this.H_Leave);
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(47, 16);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(26, 25);
            this.lblQ.TabIndex = 9;
            this.lblQ.Text = "Q";
            // 
            // lblCalculatedHash
            // 
            this.lblCalculatedHash.AutoSize = true;
            this.lblCalculatedHash.Location = new System.Drawing.Point(333, 100);
            this.lblCalculatedHash.Name = "lblCalculatedHash";
            this.lblCalculatedHash.Size = new System.Drawing.Size(146, 25);
            this.lblCalculatedHash.TabIndex = 11;
            this.lblCalculatedHash.Text = "Calculated hash";
            // 
            // lblReceivedHash
            // 
            this.lblReceivedHash.AutoSize = true;
            this.lblReceivedHash.Location = new System.Drawing.Point(333, 282);
            this.lblReceivedHash.Name = "lblReceivedHash";
            this.lblReceivedHash.Size = new System.Drawing.Size(131, 25);
            this.lblReceivedHash.TabIndex = 12;
            this.lblReceivedHash.Text = "Received hash";
            this.lblReceivedHash.Visible = false;
            // 
            // lblCalculatedSignature
            // 
            this.lblCalculatedSignature.AutoSize = true;
            this.lblCalculatedSignature.Location = new System.Drawing.Point(333, 16);
            this.lblCalculatedSignature.Name = "lblCalculatedSignature";
            this.lblCalculatedSignature.Size = new System.Drawing.Size(185, 25);
            this.lblCalculatedSignature.TabIndex = 13;
            this.lblCalculatedSignature.Text = "Calculated signature";
            // 
            // lblReceivedSignature
            // 
            this.lblReceivedSignature.AutoSize = true;
            this.lblReceivedSignature.Location = new System.Drawing.Point(333, 191);
            this.lblReceivedSignature.Name = "lblReceivedSignature";
            this.lblReceivedSignature.Size = new System.Drawing.Size(170, 25);
            this.lblReceivedSignature.TabIndex = 14;
            this.lblReceivedSignature.Text = "Received signature";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(50, 388);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(23, 25);
            this.lblK.TabIndex = 15;
            this.lblK.Text = "K";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(47, 282);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 25);
            this.lblX.TabIndex = 16;
            this.lblX.Text = "X";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(45, 191);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(25, 25);
            this.lblH.TabIndex = 17;
            this.lblH.Text = "H";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(47, 100);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(23, 25);
            this.lblP.TabIndex = 18;
            this.lblP.Text = "P";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(119, 373);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(150, 75);
            this.btnSign.TabIndex = 19;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // btnChooseSignature
            // 
            this.btnChooseSignature.Location = new System.Drawing.Point(431, 373);
            this.btnChooseSignature.Name = "btnChooseSignature";
            this.btnChooseSignature.Size = new System.Drawing.Size(150, 75);
            this.btnChooseSignature.TabIndex = 20;
            this.btnChooseSignature.Text = "Choose signature...";
            this.btnChooseSignature.UseVisualStyleBackColor = true;
            this.btnChooseSignature.Click += new System.EventHandler(this.ChooseSignature_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(275, 373);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(150, 75);
            this.btnChooseFile.TabIndex = 21;
            this.btnChooseFile.Text = "Choose file...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(587, 373);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(150, 75);
            this.btnVerify.TabIndex = 22;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.Verify_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 479);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnChooseSignature);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblReceivedSignature);
            this.Controls.Add(this.lblCalculatedSignature);
            this.Controls.Add(this.lblReceivedHash);
            this.Controls.Add(this.lblCalculatedHash);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.tbReceivedSignature);
            this.Controls.Add(this.tbCalculatedHash);
            this.Controls.Add(this.tbReceivedHash);
            this.Controls.Add(this.tbCalculatedSignature);
            this.Controls.Add(this.tbQ);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbQ;
        private TextBox tbCalculatedSignature;
        private TextBox tbReceivedHash;
        private TextBox tbCalculatedHash;
        private TextBox tbReceivedSignature;
        private TextBox tbK;
        private TextBox tbX;
        private TextBox tbP;
        private TextBox tbH;
        private Label lblQ;
        private Label lblCalculatedHash;
        private Label lblReceivedHash;
        private Label lblCalculatedSignature;
        private Label lblReceivedSignature;
        private Label lblK;
        private Label lblX;
        private Label lblH;
        private Label lblP;
        private Button btnSign;
        private Button btnChooseSignature;
        private Button btnChooseFile;
        private Button btnVerify;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}