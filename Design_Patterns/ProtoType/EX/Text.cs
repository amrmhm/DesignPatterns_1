using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.ProtoType.EX;

public class Text : Component
{
    private string content;

    public Text(string  content)
    {
        this.content = content;
    }

    public Component clone()
    {
       var newText = new Text(this.content);
        return newText;

    }

    public string getContent()
    {
        return content;
    }
}
