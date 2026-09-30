using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor;

public class PlainTextOperation : Operation
{
    public void apply(HeadingNode heading)
    {
        Console.WriteLine("Text HeadingNode");
    }

    public void apply(AnchorNode anchor)
    {
        Console.WriteLine("Text AnchorNode");

    }


}
