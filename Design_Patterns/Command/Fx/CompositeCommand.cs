using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.Fx;

public  class CompositeCommand : Command
{
    private List<Command> Commands = new List<Command>();


    public void AddCommand(Command command)
    {
        Commands.Add(command);
    }

    public void execute()
    {
        foreach (var command in Commands) 
        {
            command.execute();
        }
    }
}
