using System.Security.Cryptography;

namespace MTS_COMMON.Helper.Security
{
    public class EncryptOrDecrypt
    {
        public static string EncryptString(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateKey();
                aesAlg.GenerateIV();
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    byte[] encryptedData = msEncrypt.ToArray();
                    byte[] result = new byte[aesAlg.Key.Length + aesAlg.IV.Length + encryptedData.Length];

                    Array.Copy(aesAlg.Key, 0, result, 0, aesAlg.Key.Length);
                    Array.Copy(aesAlg.IV, 0, result, aesAlg.Key.Length, aesAlg.IV.Length);
                    Array.Copy(encryptedData, 0, result, aesAlg.Key.Length + aesAlg.IV.Length, encryptedData.Length);

                    return Convert.ToBase64String(result);
                }
            }
        }
        public static string DecryptString(string cipherText)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] key = new byte[32];
            byte[] iv = new byte[16];
            byte[] encryptedData = new byte[cipherBytes.Length - key.Length - iv.Length];

            Array.Copy(cipherBytes, 0, key, 0, key.Length);
            Array.Copy(cipherBytes, key.Length, iv, 0, iv.Length);
            Array.Copy(cipherBytes, key.Length + iv.Length, encryptedData, 0, encryptedData.Length);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(encryptedData))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
