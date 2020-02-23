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
    public partial class EncryptorForm : Form
    {
        public EncryptorForm()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            // Make sure a key file is selected.
            if(String.IsNullOrEmpty(keyfileTextBox.Text))
            {
                MessageBox.Show("You must select an ecryption key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Do work
            try
            {
                var key = Convert.FromBase64String(File.ReadAllText(keyfileTextBox.Text));

                using (var sa = TripleDES.Create())
                {
                    sa.Key = key;
                    sa.Mode = CipherMode.ECB;
                    sa.Padding = PaddingMode.PKCS7;

                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write))
                        {

                            var data = Encoding.Default.GetBytes(textBox.Text);
                            cs.Write(data, 0, data.Length);
                        }

                        using (var saveFileDlg = new SaveFileDialog())
                        {
                            saveFileDlg.Title = "Save cipher file";
                            saveFileDlg.CheckPathExists = true;
                            saveFileDlg.Filter = "Text (*.txt)|*.txt";

                            if (saveFileDlg.ShowDialog() == DialogResult.Cancel)
                            {
                                return;
                            }

                            File.WriteAllText(saveFileDlg.FileName, Convert.ToBase64String(ms.ToArray()));
                        }
                    }

                }
                

            }
            catch (Exception)
            {
                return;
            }

            MessageBox.Show("File saved to disk.", "Encrytor", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BrowseKeyButton_Click(object sender, EventArgs e)
        {
            using (var openFileDlg = new OpenFileDialog())
            {
                openFileDlg.Filter = "Text (*.txt)|*.txt";

                if (openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    keyfileTextBox.Text = openFileDlg.FileName;
                }
            }
        }
    }
}
