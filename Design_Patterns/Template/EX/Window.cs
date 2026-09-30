using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Template.EX;

public abstract class Window
{
    public void close()
    {
        //TODO: custom windows may need to execute some code before the window
        // is closed.
        onClosed();

        Console.WriteLine("Removing the window from the screen");

        //TODO: custom windows may need to execute some code after the window
        // is closed.
        onClosing();
    }

    protected abstract void onClosed();
    protected abstract void onClosing();
    
}
