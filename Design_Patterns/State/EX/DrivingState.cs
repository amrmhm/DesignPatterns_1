using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.State.EX;

public class DrivingState : State
{
    public Object Direction()
    {
        Console.WriteLine("Calculating ETA (driving)");
        return 1;

    }

    public Object ETA()
    {
        Console.WriteLine("Calculating Direction (driving)");
        return 1;

    }
}
