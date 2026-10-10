using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory.Ant;

public class AntButton : Button
{
    public void render()
    {
        Console.WriteLine("ant button");
    }
}
