using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory.Material;

public class MeterialWidgetFactory : WidgetFactory

{
    public Button createButton()
    {
        return new MeterialButton();
    }

    public TextBox createTextBox()
    {
        return new  MeterialTextBox();
    }
}
