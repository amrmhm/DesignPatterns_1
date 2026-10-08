using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Adapter.AvaFIlter;

public class Carmel
{
    public void init ()
    {

    }

    public void render(Image image)
    {
        Console.WriteLine("Rendering image with Carmel filter");
    }
}
