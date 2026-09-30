using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.Fx;

public class BlackAndWhitCommand : Command
{
    private BlackAndWhite BlackAndWhite;

    public BlackAndWhitCommand(BlackAndWhite blackAndWhite)
    {
        BlackAndWhite = blackAndWhite;
    }

    public void execute()
    {
        BlackAndWhite.B_W();
    }
}
