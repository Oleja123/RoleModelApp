using System;
using System.IO;
using System.Security.Cryptography;

public static class FileCrypto
{
    public static byte[] Encrypt(byte[] plaintext, byte[] key, byte[] iv)
    {
        using var aes = DES.Create();
        aes.Mode = CipherMode.OFB;
        aes.Padding = PaddingMode.None;
        aes.Key = key;
        aes.IV = iv;

        using var ms = new MemoryStream();
        using (var cryptoStream = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
        {
            cryptoStream.Write(plaintext, 0, plaintext.Length);
        }
        return ms.ToArray();
    }

    public static byte[] Decrypt(byte[] ciphertext, byte[] key, byte[] iv)
    {
        using var aes = DES.Create();
        aes.Mode = CipherMode.OFB;
        aes.Padding = PaddingMode.None;
        aes.Key = key;
        aes.IV = iv;

        using var ms = new MemoryStream();
        using (var cryptoStream = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
        {
            cryptoStream.Write(ciphertext, 0, ciphertext.Length);
        }
        return ms.ToArray();
    }

    public static byte[] GenerateRandomBytes(int length)
    {
        var bytes = new byte[length];
        RandomNumberGenerator.Fill(bytes);
        return bytes;
    }
}
