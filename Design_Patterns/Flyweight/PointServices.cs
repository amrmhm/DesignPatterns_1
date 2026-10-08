using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Flyweight;

public class PointServices
{
    private PointIconFactory pointFactory;

    public PointServices(PointIconFactory pointIcon)
    {
        this.pointFactory = pointIcon;
    }

    public List<Point> getPoint ()
    {

         List<Point> points = new List<Point>();
         var point = new Point(1,2, pointFactory.getPointIcons(PointType.HOSPITAL));
        points.Add(point);
        return points;
    }
}
