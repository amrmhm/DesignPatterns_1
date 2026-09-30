using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy.EX;

public class DesEncryptionAlgorithm : EncryptionAlgorithm
{
    public string encrypt(string message)
    {
            Console.WriteLine( "Encrypting message using DES");
        return "encrypted message";

    }
}
