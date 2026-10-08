using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Flyweight;

public class PointIconFactory
{
    private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

    public PointIcon getPointIcons(PointType type)
    {
        if (!icons.ContainsKey(type))
        {
            var icon = new PointIcon(type, null);

            icons.Add(type, icon);

        }

        return icons[type];
    }
}