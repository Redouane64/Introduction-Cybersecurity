using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koder2
{
    public partial class DecryptorForm : Form
    {
        public DecryptorForm()
        {
            InitializeComponent();
        }

        private void LoadKeyButton_Click(object sender, EventArgs e)
        {
            using (var openFileDlg = new OpenFileDialog())
            {
                openFileDlg.Filter = "Text (*.txt)|*.txt";

                switch (openFileDlg.ShowDialog())
                {
                    case DialogResult.Yes:
                    case DialogResult.OK:
                        keyfileTextBox.Text = openFileDlg.FileName;
                        break;
                    default:
                        return;
                }
            }
        }

        private void LoadEncryptedFileButton_Click(object sender, EventArgs e)
        {
            using (var openFileDlg = new OpenFileDialog())
            {
                openFileDlg.Filter = "Text (*.txt)|*.txt";

                switch (openFileDlg.ShowDialog())
                {
                    case DialogResult.Yes:
                    case DialogResult.OK:
                        fileTextBox.Text = openFileDlg.FileName;
                        break;
                    default:
                        return;
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(keyfileTextBox.Text))
            {
                return;
            }

            if(String.IsNullOrEmpty(fileTextBox.Text))
            {
                return;
            }

            var key = Convert.FromBase64String(File.ReadAllText(keyfileTextBox.Text));
            var encryptedData = Convert.FromBase64String(File.ReadAllText(fileTextBox.Text));

            using (var sa = TripleDES.Create())
            {
                sa.Key = key;
                sa.Padding = PaddingMode.PKCS7;
                sa.Mode = CipherMode.ECB;

                using (var output = new MemoryStream())
                {
                    using (var ms = new MemoryStream(encryptedData))
                    {
                        using (var cs = new CryptoStream(ms, sa.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            cs.CopyTo(output);
                        }
                    }

                    resultTextBox.Text = Encoding.Default.GetString(output.ToArray());
                }
            }
        }
    }
}
