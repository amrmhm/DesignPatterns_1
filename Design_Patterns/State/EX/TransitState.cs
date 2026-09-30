using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.State.EX;

public class TransitState : State
{
    public object Direction()
    {
        Console.WriteLine("Calculating ETA (transit)");
        return 3;
    }

    public object ETA()
    {

        Console.WriteLine("Calculating Direction (transit)");
        return 3;
    }
}
