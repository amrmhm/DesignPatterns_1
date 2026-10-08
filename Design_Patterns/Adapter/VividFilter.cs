using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Adapter;

public class VividFilter : Filter
{
    public void apply(Image image)
    {
        Console.WriteLine("Applying vivid filter to image");
    }
}
