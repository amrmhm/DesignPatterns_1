using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator;

public class CloudStream :Streams
{
    public  void write(string data)
    {
        Console.WriteLine($"Writing data to cloud stream: {data}");
    }
}
