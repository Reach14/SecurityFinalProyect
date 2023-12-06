using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;

namespace SecurityProyect2
{
    internal class Encriptacion{
       private readonly byte[] key = new byte[32];
       private readonly byte[] iv = new byte[16];

        private static string hashinSHA256(string dato)
        {
            // Create a SHA256 hash from string   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Computing Hash - returns here byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(dato));

                // now convert byte array to a string   
                StringBuilder stringbuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    stringbuilder.Append(bytes[i].ToString("x2"));
                }
                return stringbuilder.ToString();
            }
        }
        private static byte[] Encrypt(string plaintext, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                byte[] encryptedBytes;
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plaintext);
                        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                    }
                    encryptedBytes = msEncrypt.ToArray();
                }
                return encryptedBytes;
            }
        }

        public static string Decrypt(byte[] ciphertext, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                byte[] decryptedBytes;
                using (var msDecrypt = new System.IO.MemoryStream(ciphertext))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var msPlain = new System.IO.MemoryStream())
                        {
                            csDecrypt.CopyTo(msPlain);
                            decryptedBytes = msPlain.ToArray();
                        }
                    }
                }
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }

        public string getSHA256(string dato)
        {
            return hashinSHA256(dato);
        }

        public string getAES256Encript(string dato) {
            string encryptedText = Convert.ToBase64String(Encrypt(dato, this.key, this.iv));
            return encryptedText;
        }

        public string getAES256desEncript(string dato){
            byte[] bytes = Convert.FromBase64String(dato);
            string decryptedText = Decrypt(bytes, key, iv);
            return decryptedText;
        }

    }
}
