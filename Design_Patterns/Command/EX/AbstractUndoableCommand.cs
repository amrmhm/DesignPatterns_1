using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.EX;
public abstract class AbstractUndoableCommand : UndobaleCommand
{
    protected VideoEditor Editor;
    protected History History;

public AbstractUndoableCommand(VideoEditor videoEditor, History history)
{
    Editor = videoEditor;
    History = history;
}

    public void execute()
    {
        // Another application of the template method pattern. This method
        // is defining a template for executing commands.
        doExecute();

        History.push(this);
    }

    public void unExecute()
    {
        doUnExecute();
    }

    protected abstract void doExecute();
    protected abstract void doUnExecute();
}
