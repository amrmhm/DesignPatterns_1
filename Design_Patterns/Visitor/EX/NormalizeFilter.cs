
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor.EX;

public class NormalizeFilter : Operation
{
    public void apply(FormatSegment formatSegment)
    {
        Console.WriteLine("Normalize filter on format segment");
    }


    public void apply(FactSegment factSegment)
    {
        Console.WriteLine("Normalize filter on fact segment");
    }
}
