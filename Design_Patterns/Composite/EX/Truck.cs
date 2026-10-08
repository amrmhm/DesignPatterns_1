using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Composite.EX;

public class Truck : Component
{
    public void deploy()
    {
        Console.WriteLine("Deploying a truck");
    }
}
