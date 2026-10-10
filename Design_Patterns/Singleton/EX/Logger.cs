using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Design_Patterns.Singleton.EX;

public class Logger
{
    private string fileName;

    private static Dictionary<string, Logger> instances = new Dictionary<string, Logger>();

    private Logger(string fileName)
    {
        this.fileName = fileName;
    }
    


    public void write(string message)
    {
        Console.WriteLine("Writing a message to the log." + message);
    }

    public static Logger getInstance(string fileName)
    {
        if (!instances.ContainsKey(fileName))
        {
            instances[fileName] = new Logger(fileName);
        }

        return instances[fileName];
    }
}
