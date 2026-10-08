using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Proxy;

public class RealEBook : EBook
{
    private string fileName;

    public RealEBook(string fileName)
    {
        this.fileName = fileName;
        Load();
    }

    public void Load()
    {
        Console.WriteLine($"Loading eBook: {fileName}");
    }

    public void Show()
    {
        Console.WriteLine($"Showing eBook: {fileName}");
    }

    public string GetFileName()
    {
        return fileName;
    }
}
