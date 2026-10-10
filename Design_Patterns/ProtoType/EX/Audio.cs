using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.ProtoType.EX;

public class Audio : Component
{
    public Component clone()
    {
        return new Audio();
    }
}
