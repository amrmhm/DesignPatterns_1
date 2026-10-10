using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.FactoryMethod.EX;

internal class ArabicCalenders : Calendar
{
    public void addEvent(Events events, DateTime date)
    {
        Console.WriteLine("Adding an event on the given Arabic date.");
    }
}
