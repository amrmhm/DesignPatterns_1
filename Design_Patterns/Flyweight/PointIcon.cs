using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Flyweight;

public class PointIcon
{
    private readonly PointType pointType;
    private readonly byte[] icon;

    public PointIcon(PointType pointType, byte[] icon)
    {
        this.pointType = pointType;
        this.icon = icon;
    }


    public PointType GetPointType()
    {
        return pointType;
    }   


}
