using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.ProtoType.EX;

public class Clip : Component
{
    public Component clone()
    {
       return new Clip();
    }
}
