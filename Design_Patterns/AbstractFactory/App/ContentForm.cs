using Design_Patterns.AbstractFactory.Ant;
using Design_Patterns.AbstractFactory.Material;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory.App;

public class ContentForm
{
    public void render ( WidgetFactory widget)
    {
        widget.createTextBox().render();
        widget.createButton().render();
    }
}
