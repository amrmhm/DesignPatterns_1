using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.Editor;

public class History
{
    private List<UndoableCommand> Commands = new List<UndoableCommand>();

    public void push(UndoableCommand command)
    {
        Commands.Add(command);
    }

    public UndoableCommand pop()
    {
        var lastIndex = Commands.Count - 1;
        var lastCommand = Commands[lastIndex];
        Commands.RemoveAt(lastIndex);
        return lastCommand;
    }
    public int Count()
    {
        return Commands.Count;
    }
}
