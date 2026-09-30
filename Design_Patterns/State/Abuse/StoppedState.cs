using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.State.Abuse;

public class StoppedState : State
{
    private StopWatch StopWatch;
    public StoppedState(StopWatch stopWatch) 
    { 
        StopWatch = stopWatch;
    }
  
    public void Click()
    {
         
        StopWatch.setState(new RunningState(StopWatch));
        Console.WriteLine("StopWatch Started");
    }
}
