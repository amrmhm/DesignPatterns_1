using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Design_Patterns.ProtoType.EX;

public class ContextMenu
{
    private Timeline timeline;

    public ContextMenu(Timeline timeline)
    {
        this.timeline = timeline;
    }

    public void duplicate(Component component)
    {
       var newTimeLine =  component.clone();
        timeline.add(newTimeLine);
    }
}
