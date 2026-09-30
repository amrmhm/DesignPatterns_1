using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy;

public class BlackAndWhiteFilter : Filter
{
    public void Apply(string fileName)
    {
        Console.WriteLine("Applying BlackAndWhite Filter");

    }
}
