using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Composite.EX;

public class Team : Component
{
    private List<Component> resources = new List<Component>();

    public void add(Component resource)
    {
        resources.Add(resource);
    }

    public void deploy()
    {
        foreach (var resource in resources)
        {

            resource.deploy();

        }
}
}
