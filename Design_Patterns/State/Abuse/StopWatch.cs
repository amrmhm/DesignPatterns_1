using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.State.Abuse;

public class StopWatch
{
    private State State;

    public StopWatch(State state)
    {
        State = state;
    }

    public void Click()
    {
        State.Click();
    }

    public State getState()
    {
        return State;
    }

    public void setState(State state)
    {
        State = state;
    } 

}
