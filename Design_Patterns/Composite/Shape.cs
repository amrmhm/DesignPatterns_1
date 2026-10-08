using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Composite;

public class Shape : Component
{
    public void move()
    {
        Console.WriteLine("Moving a shape");
    }

    public void render()
    {
        Console.WriteLine("Rendering a shape");
    }
}
