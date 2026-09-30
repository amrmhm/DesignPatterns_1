using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor.EX;

public class ReverbFilter : Operation
{

    public void apply(FormatSegment formatSegment)
    {
        Console.WriteLine("Reverb filter on format segment");
    }


    public void apply(FactSegment factSegment)
    {
        Console.WriteLine("Reverb filter on fact segment");
    }
}