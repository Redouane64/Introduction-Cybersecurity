using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koder3
{
    public partial class MainForm : Form
    {
        private readonly Koder koder = new Koder();

        public MainForm()
        {
            InitializeComponent();
        }

        private void SymmetricAlgorithmChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;

            if (!rb.Checked) return;

            switch (rb.Text)
            {
                case "DES":
                    this.koder.SymmetricAlgorithm = DES.Create();
                    break;
                case "RC2":
                    this.koder.SymmetricAlgorithm = RC2.Create();
                    break;
                case "Triple DES":
                    this.koder.SymmetricAlgorithm = TripleDES.Create();
                    break;
                case "Rijndael":
                    this.koder.SymmetricAlgorithm = Rijndael.Create();
                    break;
            }

            this.GenerateKey(sender, e);
            this.GenerateVI(sender, e);
        }

        private void ModeChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;

            if (!rb.Checked) return;

            koder.SymmetricAlgorithm.Mode = (CipherMode)Enum.Parse(typeof(CipherMode), rb.Text);
        }

        private void SAPaddingChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;

            if (!rb.Checked) return;

            koder.SymmetricAlgorithm.Padding = (PaddingMode)Enum.Parse(typeof(PaddingMode), rb.Text);
        }

        private void GenerateKey(object sender, EventArgs e)
        {
            koder.GenerateKey();
            this.gKeyTextBox.Text = Convert.ToBase64String(koder.SymmetricAlgorithm.Key);
        }

        private void GenerateVI(object sender, EventArgs e)
        {
            koder.GenerateIV();
            this.ivTextBox.Text = Convert.ToBase64String(koder.SymmetricAlgorithm.IV);
        }

        private void Encrypt(object sender, EventArgs e)
        {
            try
            {
                var cipher = koder.Encrypt();
                this.cipherTextBox.Text = Convert.ToBase64String(cipher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nope!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Decrypt(object sender, EventArgs e)
        {
            recoveredPlainTextTextBox.Text = koder.Decrypt(Convert.FromBase64String(this.cipherTextBox.Text));
        }

        private void PlainTextChanged(object sender, EventArgs e)
        {
            this.koder.PlainText = (sender as TextBox).Text;
        }
    }
}
