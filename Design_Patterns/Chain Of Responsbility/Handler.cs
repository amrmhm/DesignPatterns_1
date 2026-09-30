using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility;

public abstract class Handler
{
    private Handler next;

    protected Handler(Handler next)
    {
        this.next = next;
    }


    public void handle (HttpRequest request)
    {

        if (doHandle(request))
            return;
        if(next != null)
            next.handle (request);
    }
    protected abstract bool doHandle(HttpRequest request);
}
