using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor;

public class HtmlDocument
{
    private List<HtmlNode> nodes = new List<HtmlNode>();

    public void Add (HtmlNode node)
    {
        nodes.Add(node);
    }

    public void execute(Operation operation)
    {
        foreach(var node in  nodes)
        {
            node.execute(operation);

        }
    }

}
