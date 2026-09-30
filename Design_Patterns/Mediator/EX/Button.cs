using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Design_Patterns.Mediator.EX;

public class Button : UiControl
{
    private bool IsEnable;

    public bool isEnabled()
    {
        return IsEnable;
    }

    public void setEnabled(bool enabled)
    {
        IsEnable = enabled;
        notifyObservers();

    }
}
