using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Bridge;

public class SonyTV : Device
{
    public void SetChannel(int number)
    {
        Console.WriteLine("Sony TV: Setting Channel");
    }

    public void TrunOff()
    {
        Console.WriteLine("Sony TV: Turning Off");
    }

    public void TrunOn()
    {
        Console.WriteLine("Sony TV: Turning On");
    }
}
