using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility;

public class Compressor : Handler
{
    public Compressor(Handler next) : base(next)
    {
    }


    protected override bool doHandle(HttpRequest request)
    {
        Console.WriteLine("Compressor");
        return false;

    }
}
