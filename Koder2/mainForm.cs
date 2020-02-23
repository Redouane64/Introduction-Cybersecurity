using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koder2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartKeyGenButton_Click(object sender, EventArgs e)
        {
            using (var keyGen = new KeyGenForm())
            {
                _ = keyGen.ShowDialog();
            }
        }

        private void startEncryptorButton_Click(object sender, EventArgs e)
        {
            using (var keyGen = new EncryptorForm())
            {
                _ = keyGen.ShowDialog();
            }

        }

        private void StartDecryptorButton_Click(object sender, EventArgs e)
        {
            using (var keyGen = new DecryptorForm())
            {
                _ = keyGen.ShowDialog();
            }
        }
    }
}
