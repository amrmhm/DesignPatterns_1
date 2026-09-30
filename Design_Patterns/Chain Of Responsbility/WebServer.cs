using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility;


public class WebServer
{

    private Handler next;

    public WebServer(Handler next)
    {
        if (next != null)
        {
            this.next = next;
        }
    }

    public void handle(HttpRequest request)
    {
       next.handle(request);
    }
}
