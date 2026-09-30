using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy.EX;

public interface EncryptionAlgorithm
{
    string encrypt(string message);
}
