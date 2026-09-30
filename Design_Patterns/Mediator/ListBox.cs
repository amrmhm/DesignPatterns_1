using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator;

public class ListBox : UiControl
{
    private string Selection;
    //public ListBox(DialogBox owner) : base(owner)
    //{
    //}

    public string getSelection()
    {
        return Selection;
    }

    public void setSelection(string selection)
    {
        Selection = selection;
        //owner.changed(this);
        notifyObservers();


    }
}
