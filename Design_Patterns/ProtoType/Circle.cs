using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.ProtoType;

public class Circle : Component
{
    private int radius;

    public void render()
    {
        Console.WriteLine("Rendering a circle");
    }

    public int getRadius()
    {
        return radius;
    }

    public void setRadius(int radius)
    {
        this.radius = radius;
    }

    public Component clone()
    {
       var newCircle = new Circle();
        newCircle.setRadius(this.radius);
        return newCircle;

    }
}
