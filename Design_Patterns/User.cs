using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns;

public class User
{
    public string Name;

    public User(string name)
    {
        this.Name = name;
    }

    public void sayHello()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }
}
