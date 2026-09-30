using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor.EX;

public class NoiseReductionFilter :Operation
{
    public void apply(FormatSegment formatSegment)
    {
        Console.WriteLine("Noise filter on format segment");
    }


    public void apply(FactSegment factSegment)
    {
        Console.WriteLine("Noise filter on fact segment");
    }
}
