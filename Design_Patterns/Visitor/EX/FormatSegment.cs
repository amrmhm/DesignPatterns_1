using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor.EX;


public class FormatSegment : Segment
{
    public void execute(Operation operation)
    {
        operation.apply(this);
    }
}

