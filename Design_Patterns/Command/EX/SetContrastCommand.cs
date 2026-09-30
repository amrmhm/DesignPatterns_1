using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Design_Patterns.Command.EX;

public class SetContrastCommand : AbstractUndoableCommand
{
    private float prevContrast;
    private float Contrast;

    public SetContrastCommand(float contrast , History history, VideoEditor editor) : base(editor,history )
    {
          Contrast = contrast;
          
    }

    protected override void doExecute()
    {
        Editor.setContrast(Contrast);

    }

    protected override void doUnExecute()
    {
        Editor.setContrast(prevContrast);
    }
}
