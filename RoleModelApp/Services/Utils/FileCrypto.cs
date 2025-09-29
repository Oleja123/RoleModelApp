using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.IO;
using System.Security.Cryptography;

public static class FileCrypto
{
    public static byte[] Encrypt(byte[] plaintext, byte[] key, byte[] iv)
    {
        if (key.Length != 8 || iv.Length != 8)
            throw new ArgumentException("Key and IV must be 8 bytes long for DES.");

        var engine = new DesEngine();
        var ofb = new OfbBlockCipher(engine, 64); 
        var cipher = new BufferedBlockCipher(ofb);
        cipher.Init(true, new ParametersWithIV(new KeyParameter(key), iv));

        byte[] output = new byte[cipher.GetOutputSize(plaintext.Length)];
        int len = cipher.ProcessBytes(plaintext, 0, plaintext.Length, output, 0);
        cipher.DoFinal(output, len);

        return output;
    }

    public static byte[] Decrypt(byte[] ciphertext, byte[] key, byte[] iv)
    {
        if (key.Length != 8 || iv.Length != 8)
            throw new ArgumentException("Key and IV must be 8 bytes long for DES.");

        var engine = new DesEngine();
        var ofb = new OfbBlockCipher(engine, 64);
        var cipher = new BufferedBlockCipher(ofb);
        cipher.Init(false, new ParametersWithIV(new KeyParameter(key), iv));

        byte[] output = new byte[cipher.GetOutputSize(ciphertext.Length)];
        int len = cipher.ProcessBytes(ciphertext, 0, ciphertext.Length, output, 0);
        cipher.DoFinal(output, len);

        return output;
    }

    public static byte[] GenerateRandomBytes(int length)
    {
        var bytes = new byte[length];
        RandomNumberGenerator.Fill(bytes);
        return bytes;
    }
}

