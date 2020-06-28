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

namespace Cryptography_Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RSAParameters rsaParams;
        public void GenerateNewRSAParams()
        {
            // create RSA algo.
            var rsa = new RSACryptoServiceProvider();

            // get public and private params
            rsaParams = rsa.ExportParameters(true);
            textBox1.Text = BitConverter.ToString(rsaParams.P).Replace("-", " ");
            textBox2.Text = BitConverter.ToString(rsaParams.Q).Replace("-", " ");
            textBox3.Text = BitConverter.ToString(rsaParams.Exponent).Replace("-", " ");
            textBox4.Text = BitConverter.ToString(rsaParams.D).Replace("-", " ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Generate Parameters.
            GenerateNewRSAParams();
        }

        byte[] cipherbytes;
        // Encrypt handler.
        private void button2_Click(object sender, EventArgs e)
        {
            var rsa = new RSACryptoServiceProvider();

            rsa.ImportParameters(rsaParams);

            byte[] plainbytes = Encoding.Default.GetBytes(textBox5.Text);

            cipherbytes = rsa.Encrypt(plainbytes, false);

            textBox7.Text = Encoding.Default.GetString(cipherbytes);
            textBox6.Text = BitConverter.ToString(cipherbytes).Replace("-", " ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rsa = new RSACryptoServiceProvider();

            rsa.ImportParameters(rsaParams);

            var recoveredPlainText = rsa.Decrypt(cipherbytes, false);

            textBox8.Text = Encoding.Default.GetString(recoveredPlainText);
        }
    }
}
