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
    public partial class KeyGenForm : Form
    {
        public KeyGenForm()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            const int keySize = 24; // TripleDES max key size 192Bit i.e 24 Byte.
            using (var rng = RandomNumberGenerator.Create())
            using (var saveFileDlg = new SaveFileDialog())
            {
                saveFileDlg.Title = "Save key file";
                saveFileDlg.CheckPathExists = true;
                saveFileDlg.Filter = "Text (*.txt)|*.txt";

                if(saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var file = File.CreateText(saveFileDlg.FileName))
                        {
                            byte[] key = new byte[keySize];
                            rng.GetBytes(key);

                            file.Write(Convert.ToBase64String(key));
                        }

                        MessageBox.Show("Key wriiten successfully.", "KeyGen", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Failed to write key.", "KeyGen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
