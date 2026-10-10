using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.FactoryMethod.EX;

public class ArabianScheduler : Scheduler
{
    protected override Calendar createCalender()
    {
        return new ArabicCalenders(); 
    }
}
