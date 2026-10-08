using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Adapter;

public interface Filter
{
    void apply (Image image);
}
