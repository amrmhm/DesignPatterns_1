using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Observer.EX;

public class StockListView : Observer
{
    private List<Stock> stocks = new List<Stock>();

    public void addStock(Stock stock)
    {
        stocks.Add(stock);
        stock.Add(this);


    }

    public void show()
    {
        foreach (var stock in stocks)
            Console.WriteLine(stock);
    }

    public void update()
    {
        show();
    }
}

