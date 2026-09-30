using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy.EX;

internal class AesEncryptionAlgorithm : EncryptionAlgorithm
{
    public string encrypt(string message)
    {
            Console.WriteLine ("Encrypting message using AES");
        return "encrypted message";

    }
}
