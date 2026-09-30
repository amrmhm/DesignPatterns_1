using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.State;

public class BrushTool : Tool
{
    public void MouseDown()
    {
        Console.WriteLine("Brush Icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw Line");
    }

}

