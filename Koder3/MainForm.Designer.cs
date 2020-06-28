namespace Koder3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rc2RadioButton = new System.Windows.Forms.RadioButton();
            this.rindaelRadioButton = new System.Windows.Forms.RadioButton();
            this.tripleDesRadioButton = new System.Windows.Forms.RadioButton();
            this.desRadioButton = new System.Windows.Forms.RadioButton();
            this.newRandomKeyButton = new System.Windows.Forms.Button();
            this.newIVButton = new System.Windows.Forms.Button();
            this.gKeyTextBox = new System.Windows.Forms.TextBox();
            this.ivTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctsModeRadioButton = new System.Windows.Forms.RadioButton();
            this.ofbModeRadioButton = new System.Windows.Forms.RadioButton();
            this.cfbModelRadioButton = new System.Windows.Forms.RadioButton();
            this.cbcModeRadioButton = new System.Windows.Forms.RadioButton();
            this.ecbModeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nonePaddingRadioButton = new System.Windows.Forms.RadioButton();
            this.zerosPaddingRadioButton = new System.Windows.Forms.RadioButton();
            this.pkcsPaddingRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.plainTextTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.recoveredPlainTextTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rc2RadioButton);
            this.groupBox1.Controls.Add(this.rindaelRadioButton);
            this.groupBox1.Controls.Add(this.tripleDesRadioButton);
            this.groupBox1.Controls.Add(this.desRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Symmetric Algorithm";
            // 
            // rc2RadioButton
            // 
            this.rc2RadioButton.AutoSize = true;
            this.rc2RadioButton.Location = new System.Drawing.Point(17, 88);
            this.rc2RadioButton.Name = "rc2RadioButton";
            this.rc2RadioButton.Size = new System.Drawing.Size(46, 17);
            this.rc2RadioButton.TabIndex = 3;
            this.rc2RadioButton.TabStop = true;
            this.rc2RadioButton.Text = "RC2";
            this.rc2RadioButton.UseVisualStyleBackColor = true;
            this.rc2RadioButton.CheckedChanged += new System.EventHandler(this.SymmetricAlgorithmChanged);
            // 
            // rindaelRadioButton
            // 
            this.rindaelRadioButton.AutoSize = true;
            this.rindaelRadioButton.Location = new System.Drawing.Point(17, 65);
            this.rindaelRadioButton.Name = "rindaelRadioButton";
            this.rindaelRadioButton.Size = new System.Drawing.Size(63, 17);
            this.rindaelRadioButton.TabIndex = 2;
            this.rindaelRadioButton.TabStop = true;
            this.rindaelRadioButton.Text = "Rijndael";
            this.rindaelRadioButton.UseVisualStyleBackColor = true;
            this.rindaelRadioButton.CheckedChanged += new System.EventHandler(this.SymmetricAlgorithmChanged);
            // 
            // tripleDesRadioButton
            // 
            this.tripleDesRadioButton.AutoSize = true;
            this.tripleDesRadioButton.Location = new System.Drawing.Point(17, 42);
            this.tripleDesRadioButton.Name = "tripleDesRadioButton";
            this.tripleDesRadioButton.Size = new System.Drawing.Size(76, 17);
            this.tripleDesRadioButton.TabIndex = 1;
            this.tripleDesRadioButton.TabStop = true;
            this.tripleDesRadioButton.Text = "Triple DES";
            this.tripleDesRadioButton.UseVisualStyleBackColor = true;
            this.tripleDesRadioButton.CheckedChanged += new System.EventHandler(this.SymmetricAlgorithmChanged);
            // 
            // desRadioButton
            // 
            this.desRadioButton.AutoSize = true;
            this.desRadioButton.Location = new System.Drawing.Point(17, 19);
            this.desRadioButton.Name = "desRadioButton";
            this.desRadioButton.Size = new System.Drawing.Size(47, 17);
            this.desRadioButton.TabIndex = 0;
            this.desRadioButton.TabStop = true;
            this.desRadioButton.Text = "DES";
            this.desRadioButton.UseVisualStyleBackColor = true;
            this.desRadioButton.CheckedChanged += new System.EventHandler(this.SymmetricAlgorithmChanged);
            // 
            // newRandomKeyButton
            // 
            this.newRandomKeyButton.Location = new System.Drawing.Point(160, 26);
            this.newRandomKeyButton.Name = "newRandomKeyButton";
            this.newRandomKeyButton.Size = new System.Drawing.Size(135, 23);
            this.newRandomKeyButton.TabIndex = 1;
            this.newRandomKeyButton.Text = "New Random Key";
            this.newRandomKeyButton.UseVisualStyleBackColor = true;
            this.newRandomKeyButton.Click += new System.EventHandler(this.GenerateKey);
            // 
            // newIVButton
            // 
            this.newIVButton.Location = new System.Drawing.Point(161, 82);
            this.newIVButton.Name = "newIVButton";
            this.newIVButton.Size = new System.Drawing.Size(135, 23);
            this.newIVButton.TabIndex = 2;
            this.newIVButton.Text = "New Random Init Vector";
            this.newIVButton.UseVisualStyleBackColor = true;
            this.newIVButton.Click += new System.EventHandler(this.GenerateVI);
            // 
            // gKeyTextBox
            // 
            this.gKeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gKeyTextBox.Location = new System.Drawing.Point(302, 26);
            this.gKeyTextBox.Multiline = true;
            this.gKeyTextBox.Name = "gKeyTextBox";
            this.gKeyTextBox.ReadOnly = true;
            this.gKeyTextBox.Size = new System.Drawing.Size(344, 46);
            this.gKeyTextBox.TabIndex = 3;
            // 
            // ivTextBox
            // 
            this.ivTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ivTextBox.Location = new System.Drawing.Point(302, 84);
            this.ivTextBox.Multiline = true;
            this.ivTextBox.Name = "ivTextBox";
            this.ivTextBox.ReadOnly = true;
            this.ivTextBox.Size = new System.Drawing.Size(344, 46);
            this.ivTextBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctsModeRadioButton);
            this.groupBox2.Controls.Add(this.ofbModeRadioButton);
            this.groupBox2.Controls.Add(this.cfbModelRadioButton);
            this.groupBox2.Controls.Add(this.cbcModeRadioButton);
            this.groupBox2.Controls.Add(this.ecbModeRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(161, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 47);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // ctsModeRadioButton
            // 
            this.ctsModeRadioButton.AutoSize = true;
            this.ctsModeRadioButton.Location = new System.Drawing.Point(222, 19);
            this.ctsModeRadioButton.Name = "ctsModeRadioButton";
            this.ctsModeRadioButton.Size = new System.Drawing.Size(46, 17);
            this.ctsModeRadioButton.TabIndex = 4;
            this.ctsModeRadioButton.TabStop = true;
            this.ctsModeRadioButton.Text = "CTS";
            this.ctsModeRadioButton.UseVisualStyleBackColor = true;
            this.ctsModeRadioButton.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // ofbModeRadioButton
            // 
            this.ofbModeRadioButton.AutoSize = true;
            this.ofbModeRadioButton.Location = new System.Drawing.Point(170, 19);
            this.ofbModeRadioButton.Name = "ofbModeRadioButton";
            this.ofbModeRadioButton.Size = new System.Drawing.Size(46, 17);
            this.ofbModeRadioButton.TabIndex = 3;
            this.ofbModeRadioButton.TabStop = true;
            this.ofbModeRadioButton.Text = "OFB";
            this.ofbModeRadioButton.UseVisualStyleBackColor = true;
            this.ofbModeRadioButton.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // cfbModelRadioButton
            // 
            this.cfbModelRadioButton.AutoSize = true;
            this.cfbModelRadioButton.Location = new System.Drawing.Point(119, 19);
            this.cfbModelRadioButton.Name = "cfbModelRadioButton";
            this.cfbModelRadioButton.Size = new System.Drawing.Size(45, 17);
            this.cfbModelRadioButton.TabIndex = 2;
            this.cfbModelRadioButton.TabStop = true;
            this.cfbModelRadioButton.Text = "CFB";
            this.cfbModelRadioButton.UseVisualStyleBackColor = true;
            this.cfbModelRadioButton.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // cbcModeRadioButton
            // 
            this.cbcModeRadioButton.AutoSize = true;
            this.cbcModeRadioButton.Location = new System.Drawing.Point(67, 19);
            this.cbcModeRadioButton.Name = "cbcModeRadioButton";
            this.cbcModeRadioButton.Size = new System.Drawing.Size(46, 17);
            this.cbcModeRadioButton.TabIndex = 1;
            this.cbcModeRadioButton.TabStop = true;
            this.cbcModeRadioButton.Text = "CBC";
            this.cbcModeRadioButton.UseVisualStyleBackColor = true;
            this.cbcModeRadioButton.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // ecbModeRadioButton
            // 
            this.ecbModeRadioButton.AutoSize = true;
            this.ecbModeRadioButton.Checked = true;
            this.ecbModeRadioButton.Location = new System.Drawing.Point(15, 19);
            this.ecbModeRadioButton.Name = "ecbModeRadioButton";
            this.ecbModeRadioButton.Size = new System.Drawing.Size(46, 17);
            this.ecbModeRadioButton.TabIndex = 0;
            this.ecbModeRadioButton.TabStop = true;
            this.ecbModeRadioButton.Text = "ECB";
            this.ecbModeRadioButton.UseVisualStyleBackColor = true;
            this.ecbModeRadioButton.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nonePaddingRadioButton);
            this.groupBox3.Controls.Add(this.zerosPaddingRadioButton);
            this.groupBox3.Controls.Add(this.pkcsPaddingRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(450, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 47);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Padding";
            // 
            // nonePaddingRadioButton
            // 
            this.nonePaddingRadioButton.AutoSize = true;
            this.nonePaddingRadioButton.Location = new System.Drawing.Point(145, 19);
            this.nonePaddingRadioButton.Name = "nonePaddingRadioButton";
            this.nonePaddingRadioButton.Size = new System.Drawing.Size(51, 17);
            this.nonePaddingRadioButton.TabIndex = 2;
            this.nonePaddingRadioButton.TabStop = true;
            this.nonePaddingRadioButton.Text = "None";
            this.nonePaddingRadioButton.UseVisualStyleBackColor = true;
            this.nonePaddingRadioButton.CheckedChanged += new System.EventHandler(this.SAPaddingChanged);
            // 
            // zerosPaddingRadioButton
            // 
            this.zerosPaddingRadioButton.AutoSize = true;
            this.zerosPaddingRadioButton.Location = new System.Drawing.Point(80, 19);
            this.zerosPaddingRadioButton.Name = "zerosPaddingRadioButton";
            this.zerosPaddingRadioButton.Size = new System.Drawing.Size(52, 17);
            this.zerosPaddingRadioButton.TabIndex = 1;
            this.zerosPaddingRadioButton.TabStop = true;
            this.zerosPaddingRadioButton.Text = "Zeros";
            this.zerosPaddingRadioButton.UseVisualStyleBackColor = true;
            this.zerosPaddingRadioButton.CheckedChanged += new System.EventHandler(this.SAPaddingChanged);
            // 
            // pkcsPaddingRadioButton
            // 
            this.pkcsPaddingRadioButton.AutoSize = true;
            this.pkcsPaddingRadioButton.Checked = true;
            this.pkcsPaddingRadioButton.Location = new System.Drawing.Point(15, 19);
            this.pkcsPaddingRadioButton.Name = "pkcsPaddingRadioButton";
            this.pkcsPaddingRadioButton.Size = new System.Drawing.Size(59, 17);
            this.pkcsPaddingRadioButton.TabIndex = 0;
            this.pkcsPaddingRadioButton.TabStop = true;
            this.pkcsPaddingRadioButton.Text = "PKCS7";
            this.pkcsPaddingRadioButton.UseVisualStyleBackColor = true;
            this.pkcsPaddingRadioButton.CheckedChanged += new System.EventHandler(this.SAPaddingChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.plainTextTextBox);
            this.groupBox4.Location = new System.Drawing.Point(161, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plain Text";
            // 
            // plainTextTextBox
            // 
            this.plainTextTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plainTextTextBox.Location = new System.Drawing.Point(7, 20);
            this.plainTextTextBox.Multiline = true;
            this.plainTextTextBox.Name = "plainTextTextBox";
            this.plainTextTextBox.Size = new System.Drawing.Size(472, 74);
            this.plainTextTextBox.TabIndex = 0;
            this.plainTextTextBox.TextChanged += new System.EventHandler(this.PlainTextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cipherTextBox);
            this.groupBox5.Location = new System.Drawing.Point(160, 299);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(485, 100);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cipher Text";
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cipherTextBox.Location = new System.Drawing.Point(7, 20);
            this.cipherTextBox.Multiline = true;
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.ReadOnly = true;
            this.cipherTextBox.Size = new System.Drawing.Size(472, 74);
            this.cipherTextBox.TabIndex = 0;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(12, 202);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(130, 23);
            this.encryptButton.TabIndex = 9;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.Encrypt);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(12, 412);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(130, 23);
            this.decryptButton.TabIndex = 10;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.Decrypt);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.recoveredPlainTextTextBox);
            this.groupBox6.Location = new System.Drawing.Point(162, 412);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(485, 100);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Recovered Plain Text";
            // 
            // recoveredPlainTextTextBox
            // 
            this.recoveredPlainTextTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recoveredPlainTextTextBox.Location = new System.Drawing.Point(7, 20);
            this.recoveredPlainTextTextBox.Multiline = true;
            this.recoveredPlainTextTextBox.Name = "recoveredPlainTextTextBox";
            this.recoveredPlainTextTextBox.ReadOnly = true;
            this.recoveredPlainTextTextBox.Size = new System.Drawing.Size(472, 74);
            this.recoveredPlainTextTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 540);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ivTextBox);
            this.Controls.Add(this.gKeyTextBox);
            this.Controls.Add(this.newIVButton);
            this.Controls.Add(this.newRandomKeyButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Koder3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rc2RadioButton;
        private System.Windows.Forms.RadioButton rindaelRadioButton;
        private System.Windows.Forms.RadioButton tripleDesRadioButton;
        private System.Windows.Forms.RadioButton desRadioButton;
        private System.Windows.Forms.Button newRandomKeyButton;
        private System.Windows.Forms.Button newIVButton;
        private System.Windows.Forms.TextBox gKeyTextBox;
        private System.Windows.Forms.TextBox ivTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ctsModeRadioButton;
        private System.Windows.Forms.RadioButton ofbModeRadioButton;
        private System.Windows.Forms.RadioButton cfbModelRadioButton;
        private System.Windows.Forms.RadioButton cbcModeRadioButton;
        private System.Windows.Forms.RadioButton ecbModeRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton nonePaddingRadioButton;
        private System.Windows.Forms.RadioButton zerosPaddingRadioButton;
        private System.Windows.Forms.RadioButton pkcsPaddingRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox plainTextTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox recoveredPlainTextTextBox;
    }
}

