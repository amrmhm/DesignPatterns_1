using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor.EX;

public interface Operation
{
    void apply(FactSegment segment);
    void apply(FormatSegment segment);

}
