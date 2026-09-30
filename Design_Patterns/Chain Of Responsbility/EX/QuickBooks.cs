
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility.EX;

public class QuickBooks : Handler
{
    public QuickBooks(Handler next) : base(next)
    {
    }

    protected override bool doHandle(string fileName)
    {
        
            Console.WriteLine("Reading data from a QuickBooks file.");
        return true;



    }
    protected override string getExtension()
    {
        return ".qbw";
    }
}
