using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility;

public class Logger : Handler
{
    public Logger(Handler next) : base(next)
    {
    }

    protected override bool doHandle(HttpRequest request)
    {
        Console.WriteLine("Logging");
        return false;

    }
}
