using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Iterator.EX;

public interface Iterator
{
    bool hasNext();
    void next();

    Product current();
}
