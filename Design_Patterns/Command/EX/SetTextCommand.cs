using Design_Patterns.Memento;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Design_Patterns.Command.EX;

internal class SetTextCommand : AbstractUndoableCommand
{
private string prevText;
private string Text;

    public SetTextCommand(History history, VideoEditor editor, string text) : base(editor,history)
    {

        Text = text;
    }


    protected override void doExecute()
    {
        Editor.setText(Text);
    
    }

    protected override void doUnExecute()
    {
        Editor.removeText();

    }
}
