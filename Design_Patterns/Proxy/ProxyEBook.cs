using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Proxy;

public class ProxyEBook : EBook
{
    private RealEBook realEBook;
    private string fileName;

    public ProxyEBook(string fileName)
    {
        this.fileName = fileName;
    }

    public string GetFileName()
    {
        return fileName;
    }

    public void Show()
    {
        if(realEBook == null)
        {
            realEBook = new RealEBook(fileName);
        }
        realEBook.Show();
    }
}
