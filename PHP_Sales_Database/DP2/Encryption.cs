using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace DP2
{
    public static class Encryption
    {
        private static byte[] CommonKey
        {
            get
            {
                int s = 16;
                byte[] key = new byte[s];

                for (int i = 0; i < s; ++i)
                    key[i] = (byte)((Math.PI*17)/i);

                return key;
            }
        }

        /// <summary> Converts a string to an encrypted string. ONLY FOR TESTING - difficult to convert strings back into bytes for decryption. </summary>
        public static string EncryptStringToString(string unEncryptedtext)
        {
            RijndaelManaged stringRijindael = new RijndaelManaged();
            
            stringRijindael.Key = CommonKey;
            stringRijindael.GenerateIV();

            byte[] encryptedData = EncryptStringToBytes(unEncryptedtext, CommonKey, CommonKey);
            string decrypted = DecryptStringFromBytes(encryptedData, CommonKey, CommonKey);

            string result = "";
            
            foreach (byte b in encryptedData)
                result += (char)b;

            return result;
        }

        private static byte[] EncryptLine(string unEncryptedText, byte[] IV)
        {
            if (unEncryptedText == null || unEncryptedText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (CommonKey == null || CommonKey.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            byte[] result;

            RijndaelManaged rijAlg = new RijndaelManaged();

            rijAlg.Key = CommonKey;
            rijAlg.IV = IV;

            ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
            StreamWriter swEncrypt = new StreamWriter(csEncrypt);

            swEncrypt.Write(unEncryptedText);

            swEncrypt.Flush();
            swEncrypt.Close();

            result = msEncrypt.ToArray();

            csEncrypt.Close();
            csEncrypt.Clear();
            csEncrypt.Dispose();
            msEncrypt.Close();

            return result;
        }

        public static void DecryptLine(byte[] cipherText, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (CommonKey == null || CommonKey.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null;

            RijndaelManaged rijAlg = new RijndaelManaged();
            rijAlg.Key = CommonKey;
            rijAlg.IV = IV;

            ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

            MemoryStream msDecrypt = new MemoryStream(cipherText);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
            StreamReader srDecrypt = new StreamReader(csDecrypt);

            plaintext = srDecrypt.ReadToEnd();

            srDecrypt.Close();
            csDecrypt.Close();
            csDecrypt.Clear();
            csDecrypt.Dispose();
            msDecrypt.Close();

            return plaintext;
        }

        private static byte[] EncryptStringToBytes(string unEncryptedText, byte[] key, byte[] IV)
        {
            if (unEncryptedText == null || unEncryptedText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            byte[] result;

            RijndaelManaged rijAlg = new RijndaelManaged();

            rijAlg.Key = key;
            rijAlg.IV = IV;

            ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);
            
            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
            StreamWriter swEncrypt = new StreamWriter(csEncrypt);

            swEncrypt.Write(unEncryptedText);

            swEncrypt.Flush();
            swEncrypt.Close();

            result = msEncrypt.ToArray();

            csEncrypt.Close();
            csEncrypt.Clear();
            csEncrypt.Dispose();
            msEncrypt.Close();

            return result;
        }

        private static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            
            string plaintext = null;

            RijndaelManaged rijAlg = new RijndaelManaged();
            rijAlg.Key = Key;
            rijAlg.IV = IV;
                
            ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

            MemoryStream msDecrypt = new MemoryStream(cipherText);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
            StreamReader srDecrypt = new StreamReader(csDecrypt);

            plaintext = srDecrypt.ReadToEnd();
            
            srDecrypt.Close();
            csDecrypt.Close();
            csDecrypt.Clear();
            csDecrypt.Dispose();
            msDecrypt.Close();

            return plaintext;
        }



        public static void EncryptAndStoreText(string[] unEncryptedText, string directory)
        {
            StreamWriter file = new StreamWriter("salesRecords.txt", true);
            file.WriteLine();
            for (int i = 0; i < salesGrid.Rows.Count; i++)
            {
                for (int j = 0; j < salesGrid.Rows[i].Cells.Count; j++)
                {
                    file.Write(salesGrid.Rows[i].Cells[j].Value.ToString());
                    if (j != 3) { file.Write(","); };
                }
                file.WriteLine();
            }
            file.Flush();
            file.Close();
        }

        public static string[] DecryptText(string directory)
        {

            string[] result = new string[0];
            return result;
        }


        public static string HashString(string unEncryptedText)
        {
            string result = "";
            return result;
        }

        public static bool CheckPassword(string input, string hashedPassword)
        {
            return true;
        }
    }
}
