using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Proxy.EX;

public class Product
{
    private int id;
    private string name;

    public Product(int id)
    {
        this.id = id;
    }

    public int getId()
    {
        return id;
    }

    public string getName()
    {
        return name;
    }

    public virtual void setName(string name)
    {
        this.name = name;
    }
}
