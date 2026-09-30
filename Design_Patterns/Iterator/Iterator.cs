using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Iterator;

public interface Iterator
{
    bool hasNext();
    string current();
    void next();
}
