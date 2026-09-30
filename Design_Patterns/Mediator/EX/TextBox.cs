using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator.EX;

public class TextBox : UiControl
{
    private String content;

    public String getContent()
    {
        return content;
    }

    public void setContent(String content)
    {
        this.content = content;
        notifyObservers();
    }
}
