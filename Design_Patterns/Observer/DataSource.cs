using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer;

public class DataSource : ConcreteSubject
{
    private int Value;

    public void setValue(int value)
    {
        Value = value;
        notifyObserver();
    }

    public int getValue()
    {
        return Value;
    }
}
