using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator;

public abstract class UiControl
{
  private List<Observer> Observers = new List<Observer>();

    public void addObserver(Observer observer)
    {
        Observers.Add(observer);
    }

    public void notifyObservers()
    {
        foreach (var observer in Observers)
        {
            observer();
        }
    }

  
}

