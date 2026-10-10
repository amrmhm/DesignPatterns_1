using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Design_Patterns.FactoryMethod.EX;

public class Scheduler
{


   

    public void schedule (Events events)
    {
        var calendar = createCalender();
        var today = new DateTime();
        calendar.addEvent(events, today);
    }
    protected virtual Calendar createCalender ()
    {
        return new GregorianCalendar();
    }
}
