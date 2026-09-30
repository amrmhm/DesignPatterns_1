using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility.EX;

public class DataReader
{
    private Handler Next;

    public DataReader(Handler next)
    {
        if (next != null)
        {
            this.Next = next;
        }
    }

    public void read(String fileName)
    {

      this.Next.handle(fileName);
       

    }
}
