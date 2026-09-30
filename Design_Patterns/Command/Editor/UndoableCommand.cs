using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.Editor;

public interface UndoableCommand : Command
{
    void unexecute();
}
