using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.State;

public class SelectionTool : Tool
{
    public void MouseDown()
    {
        Console.WriteLine("Selection Icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw Sqaure");
    }
    
}
