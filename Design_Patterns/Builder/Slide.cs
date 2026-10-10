using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder;

public class Slide
{
    private string text;

    public Slide(string text)
    {
        this.text = text;
    }

    public string getText()
    {
        return text;
    }
}
