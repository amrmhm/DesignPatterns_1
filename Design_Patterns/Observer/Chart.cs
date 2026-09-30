using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer;

public class Chart : Observer
{
    private DataSource DataSource;

    public Chart(DataSource dataSource)
    {
        DataSource = dataSource;
    }

    public void update()
    {
        Console.WriteLine("Chart Got Update" + " " + DataSource.getValue());
    }
}
