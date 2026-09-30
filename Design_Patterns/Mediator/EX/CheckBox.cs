using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Design_Patterns.Mediator.EX;

public class CheckBox : UiControl
{

    private bool IsCheck ;

    public bool isChecked()
    {
        return IsCheck ;
    }

    public void setChecked(bool check)
    {
        IsCheck = check;
        notifyObservers();

    }
}
