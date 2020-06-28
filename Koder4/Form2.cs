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

namespace Cryptography_Tasks
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create RSA algo
            var rsa = new RSACryptoServiceProvider();

            // get public key
            var key = rsa.ToXmlString(true);

            using (var saveFileDlg = new SaveFileDialog())
            {
                saveFileDlg.Title = "Save key file.";
                saveFileDlg.Filter = "Key (*.xml)|*.xml";

                if(saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    using (var outputFile = File.CreateText(saveFileDlg.FileName))
                    {
                        outputFile.Write(key);
                    }
                }
            }

            // show public and private key
            textBox1.Text = key;
        }

        byte[] cipherbytes;
        // Encrypt handler.
        private void button2_Click(object sender, EventArgs e)
        {
            var rsa = new RSACryptoServiceProvider();

            using (var openFileDlg = new OpenFileDialog())
            {
                openFileDlg.Title = "Select private key file";
                if(openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    var keyXML = File.ReadAllText(openFileDlg.FileName);
                    rsa.FromXmlString(keyXML);
                }
            }

            byte[] plainbytes = Encoding.Default.GetBytes(textBox5.Text);

            cipherbytes = rsa.Encrypt(plainbytes, false);

            textBox7.Text = Encoding.Default.GetString(cipherbytes);
            textBox6.Text = BitConverter.ToString(cipherbytes).Replace("-", " ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rsa = new RSACryptoServiceProvider();

            using (var openFileDlg = new OpenFileDialog())
            {
                openFileDlg.Title = "Select private key file";
                if (openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    var keyXML = File.ReadAllText(openFileDlg.FileName);
                    rsa.FromXmlString(keyXML);
                }
            }

            try
            {
                var recoveredPlainText = rsa.Decrypt(cipherbytes, false);
                textBox8.Text = Encoding.Default.GetString(recoveredPlainText);
            }
            catch (CryptographicException)
            {
                MessageBox.Show("Invalid Key!");
            }

        }
    }
}
