using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns;

public class TextBox : UiControl
{
    public override void Draw()
    {
        Console.WriteLine("Drawing TextBox...");
    }
}
