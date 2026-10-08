using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Composite;

public  class Group : Component
{
    private List<Component> Components = new List<Component>();

    public void add (Component component)
    {
        Components.Add(component);
    }

    public void move()
    {
      foreach(var component in Components)
        {
            component.move();
        }
    }

    public void render()
    {
        foreach(var component in Components)
        {
            component.render();
        }
    }
}

