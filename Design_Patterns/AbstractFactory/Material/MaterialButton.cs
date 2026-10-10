using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory.Material;

public class MeterialButton : Button
{
    public void render()
    {
        Console.WriteLine("material button ");
    }
}
