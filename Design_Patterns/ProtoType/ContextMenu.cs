using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.ProtoType;

public class ContextMenu
{

    public void Duplicate(Component component)
    {
       component.clone();
    }
}
