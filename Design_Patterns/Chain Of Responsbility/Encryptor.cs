using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility;

internal class Encryptor : Handler
{
    public Encryptor(Handler next) : base(next)
    {
    }

    protected override bool doHandle(HttpRequest request)
    {
        Console.WriteLine("Encryptor");
        return false;
    }
}
