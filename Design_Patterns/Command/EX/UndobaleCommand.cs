using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.EX;

public interface UndobaleCommand : Command
{
    void unExecute();
}
