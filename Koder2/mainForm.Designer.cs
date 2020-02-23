namespace Koder2
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
            this.startKeyGenButton = new System.Windows.Forms.Button();
            this.startEncryptorButton = new System.Windows.Forms.Button();
            this.startDecryptorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startKeyGenButton
            // 
            this.startKeyGenButton.Location = new System.Drawing.Point(12, 12);
            this.startKeyGenButton.Name = "startKeyGenButton";
            this.startKeyGenButton.Size = new System.Drawing.Size(98, 48);
            this.startKeyGenButton.TabIndex = 0;
            this.startKeyGenButton.Text = "GenKey";
            this.startKeyGenButton.UseVisualStyleBackColor = true;
            this.startKeyGenButton.Click += new System.EventHandler(this.StartKeyGenButton_Click);
            // 
            // startEncryptorButton
            // 
            this.startEncryptorButton.Location = new System.Drawing.Point(116, 12);
            this.startEncryptorButton.Name = "startEncryptorButton";
            this.startEncryptorButton.Size = new System.Drawing.Size(98, 48);
            this.startEncryptorButton.TabIndex = 1;
            this.startEncryptorButton.Text = "Encryptor";
            this.startEncryptorButton.UseVisualStyleBackColor = true;
            this.startEncryptorButton.Click += new System.EventHandler(this.startEncryptorButton_Click);
            // 
            // startDecryptorButton
            // 
            this.startDecryptorButton.Location = new System.Drawing.Point(220, 12);
            this.startDecryptorButton.Name = "startDecryptorButton";
            this.startDecryptorButton.Size = new System.Drawing.Size(98, 48);
            this.startDecryptorButton.TabIndex = 2;
            this.startDecryptorButton.Text = "Decryptor";
            this.startDecryptorButton.UseVisualStyleBackColor = true;
            this.startDecryptorButton.Click += new System.EventHandler(this.StartDecryptorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 108);
            this.Controls.Add(this.startDecryptorButton);
            this.Controls.Add(this.startEncryptorButton);
            this.Controls.Add(this.startKeyGenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Koder2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startKeyGenButton;
        private System.Windows.Forms.Button startEncryptorButton;
        private System.Windows.Forms.Button startDecryptorButton;
    }
}

