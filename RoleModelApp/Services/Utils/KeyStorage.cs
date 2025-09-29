using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services.Utils
{
    public static class KeyStorage
    {
        private static readonly int KeySize = 8;
        private static readonly int IvSize = 8;  

        public static void SaveKeyIv(byte[] key, byte[] iv, string filePath)
        {
            byte[] data = key.Concat(iv).ToArray();
            byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
            File.WriteAllBytes(filePath, encrypted);
        }

        public static (byte[] key, byte[] iv) LoadKeyIv(string filePath)
        {
            byte[] key;
            byte[] iv;
            if (!File.Exists(filePath))
            {
                key = RandomNumberGenerator.GetBytes(KeySize);
                iv = RandomNumberGenerator.GetBytes(IvSize);
                SaveKeyIv(key, iv, filePath);
                return (key, iv);
            }

            byte[] encrypted = File.ReadAllBytes(filePath);
            byte[] data = ProtectedData.Unprotect(encrypted, null, DataProtectionScope.CurrentUser);
            key = data.Take(KeySize).ToArray();
            iv = data.Skip(KeySize).Take(IvSize).ToArray();
            return (key, iv);
        }
    }

}
