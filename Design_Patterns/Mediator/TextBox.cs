using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator;

public class TextBox : UiControl
{
    private string Content;

    //public TextBox(DialogBox owner) : base(owner)
    //{
    //}

    public string getContent()
    {
        return Content;
    }

    public void setContent(string content)
    {
        Content = content;
        //owner.changed(this);
        notifyObservers();
    }
}
