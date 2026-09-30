using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Design_Patterns.State.Abuse;

public class RunningState : State
{
    private StopWatch StopWatch;
    public RunningState(StopWatch stopWatch) 
    {
        StopWatch = stopWatch;
    }
    public  void Click()
    {
        StopWatch.setState(new StoppedState(StopWatch));
        Console.WriteLine("StopWatch Stopped");
    }
}
