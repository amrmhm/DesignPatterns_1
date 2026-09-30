using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.Fx;

public class ResizeCommand : Command
{
    private Resize Resize;
public ResizeCommand(Resize resize)
    {
        Resize = resize;
    }

    public void execute()
    {
        Resize.Size(); 
    }
}
