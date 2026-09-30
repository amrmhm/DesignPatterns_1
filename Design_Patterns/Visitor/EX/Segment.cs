using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor.EX;

public interface Segment
{

    void execute(Operation operation);
    
}