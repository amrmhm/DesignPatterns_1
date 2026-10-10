using Design_Patterns.AbstractFactory.Material;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory.Ant;

public class AntWidgetFactory : WidgetFactory
{
    public Button createButton()
    {
        return new AntButton();
    }

    public TextBox createTextBox()
    {
        return new AntTextBox();
    }
}
