using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.ProtoType.EX;

public interface Component
{
    Component clone();
}
