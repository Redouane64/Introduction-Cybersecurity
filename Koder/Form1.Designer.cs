namespace Koder
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.codeButton = new System.Windows.Forms.Button();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 13);
            label1.TabIndex = 0;
            label1.Text = "Cipher Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 49);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 13);
            label2.TabIndex = 1;
            label2.Text = "Plain Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(46, 86);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(28, 13);
            label3.TabIndex = 2;
            label3.Text = "Text";
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(198, 109);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(75, 23);
            this.codeButton.TabIndex = 3;
            this.codeButton.Text = "Code";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.CodeButton_Click);
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Location = new System.Drawing.Point(80, 10);
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(193, 20);
            this.cipherTextBox.TabIndex = 4;
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(80, 46);
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(193, 20);
            this.plainTextBox.TabIndex = 5;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(80, 83);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(193, 20);
            this.textBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 144);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.cipherTextBox);
            this.Controls.Add(this.codeButton);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "MainForm";
            this.Text = "Koder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.TextBox textBox;
    }
}

