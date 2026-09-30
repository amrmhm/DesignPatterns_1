using Design_Patterns.Command.Editor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.EX;

public class History
{
    private List<UndobaleCommand> Commands = new List<UndobaleCommand>();

    public void push(UndobaleCommand  command)
    {
        Commands.Add(command);
    }

    public UndobaleCommand pop()
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
