using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer.EX;

public class ConcreteSubject : Subject
{
    private List<Observer> Observers = new List<Observer>(); 
    protected override void addObserver(Observer observer)
    {
        Observers.Add(observer);
    }

    protected override void notifyObserver()
    {
       foreach(var  observer in Observers)
        {
            observer.update();
        }
    }

    protected override void removeObserver(Observer observer)
    {
        Observers.Remove(observer);
    }


    public  void Add(Observer observer)
    {
        addObserver(observer);
    }
}
