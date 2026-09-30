using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer.EX;

public class Stock : ConcreteSubject
{

    private string symbol;
    private float price;

    public Stock(string symbol, float price)
    {
        this.symbol = symbol;
        this.price = price;
    }

    public float getPrice()
    {
        return price;

    }

    public void setPrice(float price)
    {
        this.price = price;
        notifyObserver();

    }

    
    public override string ToString()
    {
        return "Stock{" +
                "symbol='" + symbol + '\'' +
                ", price=" + price +
                '}';
    }
}

