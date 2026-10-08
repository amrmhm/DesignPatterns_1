using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade;

public class Connection
{
    public void disConnect()
    {
        Console.WriteLine("Disconnected from the database.");
    }
}
