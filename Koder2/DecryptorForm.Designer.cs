namespace Koder2
{
    partial class DecryptorForm
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
            this.loadKeyButton = new System.Windows.Forms.Button();
            this.loadEncryptedFileButton = new System.Windows.Forms.Button();
            this.keyfileTextBox = new System.Windows.Forms.TextBox();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loadKeyButton
            // 
            this.loadKeyButton.Location = new System.Drawing.Point(303, 13);
            this.loadKeyButton.Name = "loadKeyButton";
            this.loadKeyButton.Size = new System.Drawing.Size(75, 23);
            this.loadKeyButton.TabIndex = 0;
            this.loadKeyButton.Text = "Load Key";
            this.loadKeyButton.UseVisualStyleBackColor = true;
            this.loadKeyButton.Click += new System.EventHandler(this.LoadKeyButton_Click);
            // 
            // loadEncryptedFileButton
            // 
            this.loadEncryptedFileButton.Location = new System.Drawing.Point(303, 42);
            this.loadEncryptedFileButton.Name = "loadEncryptedFileButton";
            this.loadEncryptedFileButton.Size = new System.Drawing.Size(75, 23);
            this.loadEncryptedFileButton.TabIndex = 1;
            this.loadEncryptedFileButton.Text = "Load File";
            this.loadEncryptedFileButton.UseVisualStyleBackColor = true;
            this.loadEncryptedFileButton.Click += new System.EventHandler(this.LoadEncryptedFileButton_Click);
            // 
            // keyfileTextBox
            // 
            this.keyfileTextBox.Location = new System.Drawing.Point(50, 15);
            this.keyfileTextBox.Name = "keyfileTextBox";
            this.keyfileTextBox.Size = new System.Drawing.Size(247, 20);
            this.keyfileTextBox.TabIndex = 2;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(50, 44);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(247, 20);
            this.fileTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(143, 70);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(89, 30);
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 106);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(366, 154);
            this.resultTextBox.TabIndex = 7;
            // 
            // DecryptorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 272);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.keyfileTextBox);
            this.Controls.Add(this.loadEncryptedFileButton);
            this.Controls.Add(this.loadKeyButton);
            this.Name = "DecryptorForm";
            this.Text = "Decryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadKeyButton;
        private System.Windows.Forms.Button loadEncryptedFileButton;
        private System.Windows.Forms.TextBox keyfileTextBox;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}