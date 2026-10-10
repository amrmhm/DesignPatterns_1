using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder.EX;

public class Image :Element
{
    private string source;

    public Image(string source)
    {
        this.source = source;
    }

    public string getSource()
    {
        return source;
    }
}
