using System;
using OpenClosedPrinciple;

public class Program
{
    public static void Main()
    {
        IEncryptionStrategy aesStrategy = new AesEncryption();
        Encryption aesEncryption = new Encryption(aesStrategy);
        string aesEncryptedData = aesEncryption.Encrypt("sample data");
        Console.WriteLine(aesEncryptedData);

        IEncryptionStrategy rsaStrategy = new RsaEncryption();
        Encryption rsaEncryption = new Encryption(rsaStrategy);
        string rsaEncryptedData = rsaEncryption.Encrypt("sample data");
        Console.WriteLine(rsaEncryptedData);
    }
}


