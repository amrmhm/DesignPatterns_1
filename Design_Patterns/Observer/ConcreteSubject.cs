using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer;

public class ConcreteSubject : Subject
{
    private List<Observer> observers = new List<Observer>();

    protected override void addObserver(Observer observer)
    {
        observers.Add(observer);
    }

    protected override void notifyObserver()
    {
        foreach(var  observer in observers)
            observer.update();
    }

    protected override void removeObserver(Observer observer)
    {
        observers.Remove(observer);
    }

    public void Add (Observer observer)
    {
        addObserver(observer);
    }
}
