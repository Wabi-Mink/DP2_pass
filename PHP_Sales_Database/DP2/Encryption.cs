using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

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
                {
                    key[i] = (byte)((Math.PI * 17) / i);
                }

                return key;
            }
        }

        /// <summary> [Deprecated] Encrypt a single string into a byte array, using the CommonKey and the specified IV (symetric encryption). Decrypted using 'DecryptLine()'. </summary>
        private static byte[] EncryptLine(string unEncryptedText, byte[] IV)
        {
            if (unEncryptedText == null || unEncryptedText.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }

            if (CommonKey == null || CommonKey.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }

            if (IV == null || IV.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

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

        /// <summary> [Deprecated] Decrypt a byte array back into a single string, using the CommonKey and the specified IV (symetric encryption). Opposite of 'EncryptLine()'. </summary>
        private static string DecryptLine(byte[] cipherText, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
            {
                throw new ArgumentNullException("cipherText");
            }

            if (CommonKey == null || CommonKey.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }

            if (IV == null || IV.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

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

        /// <summary> Encrypts an array of strings and saves them to the specified directory. Use 'DecryptFileToText()' to recover.
        /// Extension should NOT be .txt (e.g. use .dat), but can be for testing.
        /// Notes: Uses a predefined key (CommonKey), and a randomly generated IV which is saved at the start of the file. </summary>
        public static void EncryptAndStoreText(string[] unEncryptedText, string directory)
        {
            RijndaelManaged stringRijindael = new RijndaelManaged();
            stringRijindael.GenerateIV();

            FileStream file = new FileStream(directory, FileMode.Create);

            file.Write(stringRijindael.IV, 0, stringRijindael.IV.Length);
            byte[] encryptedData = EncryptSeries(unEncryptedText, stringRijindael.IV);
            file.Write(encryptedData, 0, encryptedData.Length);

            file.Flush();
            file.Close();
        }

        /// <summary> Opposite of 'EncryptAndStoreText()'. Decrypts a file and generates from it the list of strings which were encrypted. </summary>
        public static string[] DecryptFileToText(string directory)
        {
            FileStream file = new FileStream(directory, FileMode.Open);

            byte[] IV = new byte[16];
            file.Read(IV, 0, 16);
            int length = (int)file.Length - 16;
            byte[] contents = new byte[length];
            long fl = file.Length;
            file.Read(contents, 0, length);

            string[] output = DecryptSeries(contents, IV);

            file.Flush();
            file.Close();

            return output;
        }

        /// <summary> Used by 'EncryptAndStoreText()' to encrypt an array of strings. </summary>
        private static byte[] EncryptSeries(string[] unEncryptedText, byte[] IV)
        {
            if (unEncryptedText == null || unEncryptedText.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }

            if (CommonKey == null || CommonKey.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }

            if (IV == null || IV.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

            byte[] result;

            RijndaelManaged rijAlg = new RijndaelManaged();

            rijAlg.Key = CommonKey;
            rijAlg.IV = IV;

            ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
            StreamWriter swEncrypt = new StreamWriter(csEncrypt);

            foreach (string line in unEncryptedText)
            {
                swEncrypt.WriteLine(line);
            }

            swEncrypt.Flush();
            swEncrypt.Close();

            result = msEncrypt.ToArray();

            csEncrypt.Close();
            csEncrypt.Clear();
            csEncrypt.Dispose();
            msEncrypt.Close();

            return result;
        }

        /// <summary> Used by 'DecryptFileToText()' to decrypt a random sequence of bytes back into an array of strings. </summary>
        private static string[] DecryptSeries(byte[] cipherText, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
            {
                throw new ArgumentNullException("cipherText");
            }

            if (CommonKey == null || CommonKey.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }

            if (IV == null || IV.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

            List<string> plaintext = new List<string>();

            RijndaelManaged rijAlg = new RijndaelManaged();
            rijAlg.Key = CommonKey;
            rijAlg.IV = IV;

            ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

            MemoryStream msDecrypt = new MemoryStream(cipherText);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
            StreamReader srDecrypt = new StreamReader(csDecrypt);

            while (!srDecrypt.EndOfStream)
            {
                plaintext.Add(srDecrypt.ReadLine());
            }

            srDecrypt.Close();
            csDecrypt.Close();
            csDecrypt.Clear();
            csDecrypt.Dispose();
            msDecrypt.Close();

            return plaintext.ToArray();
        }

        /// <summary> Used to convert any single string into a 32 byte Hashed value. </summary>
        private static byte[] HashString(string unEncryptedText)
        {
            SHA256 mainSHA = SHA256.Create();

            byte[] result = mainSHA.ComputeHash(Encoding.ASCII.GetBytes(unEncryptedText));
            return result;
        }

        /// <summary> Used for debugging only. </summary>
        public static string ByteArrayToString(byte[] input)
        {
            string s = "";

            foreach (byte b in input)
            {
                s += (int)b + " ";
            }

            return s;
        }

        /// <summary> Check if the hashed value of both the username AND password exists within the specified file. </summary>
        public static bool CheckPassword(string username, string password, string directoryOfPasswords)
        {
            byte[] inName = HashString(username);
            byte[] inPassword = HashString(password);

            byte[] originalName = HashString(username);
            byte[] originalPassword = HashString(password);

            if (!File.Exists(directoryOfPasswords))
            {
                FileStream file = new FileStream(directoryOfPasswords, FileMode.Create);
                return false;
            }
            else
            {
                FileStream file = new FileStream(directoryOfPasswords, FileMode.Open);
                bool foundPW = false;
                while (!foundPW)
                {
                    int count = file.Read(originalName, 0, 32);
                    count += file.Read(originalPassword, 0, 32);
                    if (count < 32)
                    {
                        break;
                    }

                    if (HashEquals(originalName, inName) && HashEquals(originalPassword, inPassword))
                    {
                        foundPW = true;
                    }
                }

                file.Flush();
                file.Close();

                return foundPW;
            }
        }

        /// <summary> Used to compare byte arrays since hashed values are arrays and therefore == will fail. </summary>
        private static bool HashEquals(byte[] A, byte[] B)
        {
            if (A.Length != B.Length)
            {
                return false;
            }

            for (int i = 0; i < A.Length; ++i)
            {
                if (A[i] != B[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary> Checks if the username already exists in the UN/PW file, e.g. so that duplicate accounts cannot be created. </summary>
        public static bool CheckUserExists(string username, string directoryOfPasswords)
        {
            byte[] inName = HashString(username);

            byte[] originalName = HashString(username);
            byte[] originalPassword = new byte[32];

            FileStream file;
            if (!File.Exists(directoryOfPasswords))
            {
                file = new FileStream(directoryOfPasswords, FileMode.Create);
            }
            else
            {
                file = new FileStream(directoryOfPasswords, FileMode.Open);
            }

            bool foundName = false;
            while (!foundName)
            {
                int count = file.Read(originalName, 0, 32);
                count += file.Read(originalPassword, 0, 32);
                if (count < 32)
                {
                    break;
                }

                if (HashEquals(originalName, inName))
                {
                    foundName = true;
                }
            }

            file.Flush();
            file.Close();

            return foundName;
        }

        /// <summary> Saves a NEW hashed username and password to the file. Does NOT check if the username already exists. Use 'CheckUserExists' for this. </summary>
        public static void SaveNameAndPassword(string username, string password, string directoryOfPasswords)
        {
            byte[] hashedName = HashString(username);
            byte[] hashedPassword = HashString(password);

            FileStream file = new FileStream(directoryOfPasswords, FileMode.Append);
            file.Write(hashedName, 0, hashedName.Length);
            file.Write(hashedPassword, 0, hashedPassword.Length);

            file.Flush();
            file.Close();
        }

        //To be added:
        //'ChangePassword' function.
    }
}
