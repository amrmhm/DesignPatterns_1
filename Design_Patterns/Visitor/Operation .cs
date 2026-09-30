using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor;

public interface Operation
{
    void apply(HeadingNode heading);
    void apply(AnchorNode anchor);
}
