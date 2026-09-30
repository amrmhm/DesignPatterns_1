using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor;

public class HighLigthOperation : Operation
{
    public void apply(HeadingNode heading)
    {
        Console.WriteLine("HighLigth HeadingNode");
    }

    public void apply(AnchorNode anchor)
    {
        Console.WriteLine("HighLigth AnchorNode");
    }
}
