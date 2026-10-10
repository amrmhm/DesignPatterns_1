using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory.Material;

public class MeterialTextBox : TextBox
{
    public void render()
    {
        Console.WriteLine("material textbox");
    }
}
