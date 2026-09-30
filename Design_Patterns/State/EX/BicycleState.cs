using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.State.EX;

public class BicycleState : State
{
    public object Direction()
    {
        Console.WriteLine("Calculating ETA (bicycling)");
        return 2;
    }

    public object ETA()
    {
        Console.WriteLine("Calculating Direction (bicycling)");
        return 2;
    }
}
