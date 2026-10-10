using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder.EX.Html;

public class HtmlParagraph : HtmlElement
{
    private string text;

    public HtmlParagraph(string text)
    {
        this.text = text;
    }

   
    public override string ToString()
    {
        return string.Format($"<p>{text}</p>");
    }
}
