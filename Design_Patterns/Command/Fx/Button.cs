using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.Fx;

public class Button
{
    private string Label;
    private Command Command;

    public Button(Command command)
    {
        Command = command;
    }

    public void click()
    {
        Command.execute();
    }

    

    public string getLabel()
    {
        return Label;
    }

    public void setLabel(string label)
    {
        Label = label;
    }
}
