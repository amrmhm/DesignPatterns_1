using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility;

public class Authenticator : Handler
{
    public Authenticator(Handler next) : base(next)
    {
    }

    protected override bool doHandle(HttpRequest request)
    {
        var isValid = (request.getUserName() == "Admin" && request.getPassword() == "1234");
        Console.WriteLine("Authenticator");

        return !isValid;
    }
}
