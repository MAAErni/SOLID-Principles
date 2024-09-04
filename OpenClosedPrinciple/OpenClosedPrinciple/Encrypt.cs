using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class AesEncryption : IEncryptionStrategy
    {
        public string Encrypt(string data)
        {
            return "AES Encrypted data";
        }
    }

    public class RsaEncryption : IEncryptionStrategy
    {
        public string Encrypt(string data)
        {
            return "RSA Encrypted data";
        }
    }


    public class Encryption
    {
        private readonly IEncryptionStrategy _encryptionStrategy;

        public Encryption(IEncryptionStrategy encryptionStrategy)
        {
            _encryptionStrategy = encryptionStrategy;
        }

        public string Encrypt(string data)
        {
            return _encryptionStrategy.Encrypt(data);
        }
    }
}


