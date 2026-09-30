using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Template.EX;

public class ChartWindow : Window
{
    protected override void onClosed()
    {
        Console.WriteLine("1");
    }

    protected override void onClosing()
    {
        Console.WriteLine("2");
    }
}
