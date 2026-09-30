using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor;

public class HeadingNode : HtmlNode
{
    public void execute(Operation operation)
    {
        operation.apply(this);
    }

  
}
