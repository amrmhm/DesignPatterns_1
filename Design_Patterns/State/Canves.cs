using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.State;

public class Canves
{
    private Tool currentTool;
    public void MouseDown()
    {
        currentTool.MouseDown();
    }
    public void MouseUp()
    {
       currentTool.MouseUp();

    }

    public Tool getTool()
    {
        return currentTool;
    }
    public void setTool(Tool tool)
    {
        currentTool = tool;
    }
}
