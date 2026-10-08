using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Proxy;

public class Libarary
{
    private Dictionary<string, EBook> eBooks = new Dictionary<string, EBook>();
    public void Add (EBook eBook)
    {
        eBooks.Add(eBook.GetFileName(), eBook);
    }

    public void openEbook(string fileName)
    {
        eBooks[fileName].Show();
    }
}
