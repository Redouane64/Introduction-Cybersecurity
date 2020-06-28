using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Koder3
{
    public class Koder
    {

        public Koder()
        {
        }

        public SymmetricAlgorithm SymmetricAlgorithm { get; set; }

        public string PlainText { get; set; }

        public void GenerateKey()
        {
            SymmetricAlgorithm.GenerateKey();
        }

        public void GenerateIV()
        {
            SymmetricAlgorithm.GenerateIV();
        }

        public byte[] Encrypt()
        {
            if(String.IsNullOrEmpty(PlainText))
            {
                throw new InvalidOperationException("You must enter some text to encrypt.");
            }

            var data = Encoding.Default.GetBytes(PlainText);

            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, SymmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                }

                return ms.ToArray();
            }
        }

        public string Decrypt(byte[] cipherText)
        {
            if (cipherText == null)
            {
                return String.Empty;
            }

            using(var output = new MemoryStream())
            using (var ms = new MemoryStream(cipherText))
            {
                using (var cs = new CryptoStream(ms, SymmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cs.CopyTo(output);
                }

                return Encoding.Default.GetString(output.ToArray());
            }
        }

    }
}
