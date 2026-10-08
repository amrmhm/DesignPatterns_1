using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Bridge;

public class LGTV : Device
{
    public void SetChannel(int number)
    {
        Console.WriteLine("Setting channel to  LG TV");
    }

    public void TrunOff()
    {
        Console.WriteLine("Turning off LG TV");
    }

    public void TrunOn()
    {
        Console.WriteLine("Turning on LG TV");
    }
}
