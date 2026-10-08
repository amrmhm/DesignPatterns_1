using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Flyweight;

public class Point
{
    private int x;
    private int y;
    private PointIcon pointIcon;


    public Point(int x, int y, PointIcon pointIcon)
    {
        this.x = x;
        this.y = y;
        this.pointIcon = pointIcon;
    }


    public void draw ()
    {
        Console.WriteLine($"{pointIcon.GetPointType()} at ({x},{y})");
    }

    
}
