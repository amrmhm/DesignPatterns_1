using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer;

public abstract class Subject
{

    protected abstract void addObserver(Observer observer);
    protected abstract void removeObserver(Observer observer);
    protected abstract void notifyObserver();

}
