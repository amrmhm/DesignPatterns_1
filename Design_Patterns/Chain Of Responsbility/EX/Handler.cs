using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility.EX;

public abstract class Handler
{
    private Handler Next;

    public Handler(Handler next)
    {
        this.Next = next;
    }

    public void handle(string filName)
    {
        if (filName.EndsWith(getExtension()))
        {
            if (doHandle(filName))

                return;
        }

            if (this.Next != null)
                this.Next.handle(filName);
        else
            throw new Exception("File format not supported.");
    }
        

    
    protected abstract bool doHandle(string fileName);
    protected abstract String getExtension();
}
