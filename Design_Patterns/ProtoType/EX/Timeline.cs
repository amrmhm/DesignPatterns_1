using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.ProtoType.EX;

public class Timeline
{
    private List<Component> components = new List<Component>();

    public void add(Component component)
    {
        components.Add(component);
    }
}
