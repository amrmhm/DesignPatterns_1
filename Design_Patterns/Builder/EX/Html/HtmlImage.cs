using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder.EX.Html;

public class HtmlImage : HtmlElement
{
    private string source;

    public HtmlImage(string source)
    {
        this.source = source;
    }

    
    public override string ToString()
    {
        return string.Format($"<img src=\"{source}\" />");
    }
}
