using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Proxy;

public class loggingEBook : EBook
{
    private string fileName;
    private RealEBook realEBook;

    public loggingEBook(string fileName)
    {
        this.fileName = fileName;
    }

    public string GetFileName()
    {
        return fileName;
    }

    public void Show()
    {
        if (realEBook == null)
        {
            realEBook = new RealEBook(fileName);
        }
        Console.WriteLine("Logging EBook: " + fileName);
        realEBook.Show();
    }
}
