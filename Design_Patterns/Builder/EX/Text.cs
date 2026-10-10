using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder.EX;

public class Text : Element
{
    private string content;

    public Text(string content)
    {
        this.content = content;
    }

    public string getContent()
    {
        return content;
    }
}
