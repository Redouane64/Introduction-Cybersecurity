namespace Koder2
{
    partial class EncryptorForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyfileTextBox = new System.Windows.Forms.TextBox();
            this.browseKeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 37);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(411, 147);
            this.textBox.TabIndex = 0;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(173, 190);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(89, 34);
            this.encryptButton.TabIndex = 1;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key";
            // 
            // keyfileTextBox
            // 
            this.keyfileTextBox.Location = new System.Drawing.Point(45, 13);
            this.keyfileTextBox.Name = "keyfileTextBox";
            this.keyfileTextBox.Size = new System.Drawing.Size(312, 20);
            this.keyfileTextBox.TabIndex = 3;
            // 
            // browseKeyButton
            // 
            this.browseKeyButton.Location = new System.Drawing.Point(363, 13);
            this.browseKeyButton.Name = "browseKeyButton";
            this.browseKeyButton.Size = new System.Drawing.Size(60, 20);
            this.browseKeyButton.TabIndex = 4;
            this.browseKeyButton.Text = "Browse";
            this.browseKeyButton.UseVisualStyleBackColor = true;
            this.browseKeyButton.Click += new System.EventHandler(this.BrowseKeyButton_Click);
            // 
            // EncryptorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 237);
            this.Controls.Add(this.browseKeyButton);
            this.Controls.Add(this.keyfileTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EncryptorForm";
            this.Text = "Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyfileTextBox;
        private System.Windows.Forms.Button browseKeyButton;
    }
}