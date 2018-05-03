using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesLibrary
{
    public class StringPassword
    {
        const int size = 256;
        const int interation = 160;
        public static string EncrytString(string text, string stringKey)
        {
            var saltStringBytes = Random256bitsGenerator();
            var ivStringBytes = Random256bitsGenerator();
            var TextBytes = Encoding.UTF8.GetBytes(text);
            var password = new Rfc2898DeriveBytes(stringKey, saltStringBytes, interation);
            var key = password.GetBytes(size / 8);
            var rijndael = new RijndaelManaged();
            rijndael.BlockSize = 256;
            rijndael.Mode = CipherMode.CBC;
            rijndael.Padding = PaddingMode.PKCS7;
            var encryptor = rijndael.CreateEncryptor(key, ivStringBytes);
            var memory = new MemoryStream();
            var cryptorStream = new CryptoStream(memory, encryptor, CryptoStreamMode.Write);
            cryptorStream.Write(TextBytes, 0, TextBytes.Length);
            cryptorStream.FlushFinalBlock();
            var pwTextBytes = saltStringBytes;
            pwTextBytes = pwTextBytes.Concat(ivStringBytes).ToArray();
            pwTextBytes = pwTextBytes.Concat(memory.ToArray()).ToArray();
            memory.Close();
            cryptorStream.Close();
            return Convert.ToBase64String(pwTextBytes);
        }

        public static string DecrytString(string encryptString, string stringKey)
        {
            var pwBytesSaltAndIV = Convert.FromBase64String(encryptString);
            var SaltStringBytes = pwBytesSaltAndIV.Take(size / 8).ToArray();
            var ivStringBytes = pwBytesSaltAndIV.Skip(size / 8).Take(size / 8).ToArray();
            var pwBytes = pwBytesSaltAndIV.Skip((size * 2) / 8).Take(pwBytesSaltAndIV.Length - (size * 2) / 8).ToArray();
            var password = new Rfc2898DeriveBytes(stringKey, SaltStringBytes, interation);
            var key = password.GetBytes(size / 8);
            var rijndael = new RijndaelManaged();
            rijndael.BlockSize = 256;
            rijndael.Mode = CipherMode.CBC;
            rijndael.Padding = PaddingMode.PKCS7;
            var decryptor = rijndael.CreateDecryptor(key, ivStringBytes);
            var memory = new MemoryStream(pwBytes);
            var cryptorStream = new CryptoStream(memory, decryptor, CryptoStreamMode.Read);
            var textBytes = new byte[pwBytes.Length];
            var count = cryptorStream.Read(textBytes, 0, textBytes.Length);
            memory.Close();
            cryptorStream.Close();
            return Encoding.UTF8.GetString(textBytes, 0, count);
        }

        private static byte[] Random256bitsGenerator()
        {
            var random = new byte[32];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(random);
            return random;
        }
        public static string RandomStringGenerator(int size)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            char c;
            for (int i = 0; i < size; i++)
            {
                var temp = random.Next(0, 37);
                if (temp > 26)
                {
                    c = Convert.ToChar(temp - 27 + '0');
                }
                else c = Convert.ToChar(temp + 65);
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
