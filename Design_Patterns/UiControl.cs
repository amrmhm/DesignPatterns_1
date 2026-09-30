using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns;

public abstract class UiControl
{
    public void Enable()
    {
        Console.WriteLine("UI Control enabled.");
    }
    public abstract void Draw();
}
