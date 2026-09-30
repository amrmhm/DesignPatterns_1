using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility.EX;

public class Excel : Handler
{
    public Excel(Handler next) : base(next)
    {
    }

    protected override bool doHandle(string fileName)
    {
       
            Console.WriteLine("Reading data from an Excel spreadsheet.");
        return true;

    }

    protected override string getExtension()
    {
        return ".xls";
    }
}
