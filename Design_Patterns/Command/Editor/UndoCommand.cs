using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.Editor;

public class UndoCommand : Command
{
    private History History;

    public UndoCommand(History history)
    {
        History = history;
    }

    public void execute()
    {
        if (History.Count() > 0)
        {
            History.pop().unexecute();
        }
    }
}
