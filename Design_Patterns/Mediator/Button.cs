using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator;

public class Button : UiControl
{
    private bool isEnabled;

    //public Button(DialogBox owner) : base(owner)
    //{
    //}

    public void setEnabled(bool enabled)
    {
        isEnabled = enabled;
    }
    public bool getEnable()
    {
        return isEnabled;
        //owner.changed(this);
        notifyObservers();

    }
}
