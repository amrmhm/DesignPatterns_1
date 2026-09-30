using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer;

public class SpreedSheet : Observer
{
    private DataSource DataSource;

    public SpreedSheet(DataSource dataSource)
    {
        DataSource = dataSource;
    }

    public void update()
    {
        Console.WriteLine("SpreedSheet got Notification" + " " + DataSource.getValue());
    }
}
