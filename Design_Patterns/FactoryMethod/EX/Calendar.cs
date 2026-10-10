using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.FactoryMethod.EX;

public interface Calendar
{
    public void addEvent(Events events, DateTime date);
}
