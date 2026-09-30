using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility.EX;


public class DataReaderFactory
{
    public static Handler getDataReaderChain()
    {
        var excelReader = new Excel(null);
        var numbersReader = new Numbers(excelReader);
        var quickBooksReader = new QuickBooks(numbersReader);


        return quickBooksReader;
    }
}
