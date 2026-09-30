using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.Editor;

public class HtmlDocument
{
    private string Content;

    public void BoldContent()
    {
        Content = "<b>" + Content + "</b>";
    }


    public void setContent(string content)
    {
        Content = content;
    }

    public string getContent()
    {
        return Content;
    }
}
