using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder;

public class PDFDocument
{
    public void addPage (string text)
    {
        Console.WriteLine("Add text To Page");
    }
}
