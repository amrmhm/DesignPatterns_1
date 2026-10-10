using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory;

public interface WidgetFactory
{
    Button createButton();
    TextBox createTextBox();
}
