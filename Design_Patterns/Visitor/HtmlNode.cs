using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor;

public interface HtmlNode
{
    void execute(Operation operation);

}
