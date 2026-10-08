using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade;

public class NotificationServer
{
    public Connection connection (string ipAddress)
    {
        return new Connection();
    }

    public AuthToken authention (string appId , string key)
    {
        return new AuthToken();
    }
    public void send (AuthToken authToken , Message message , string target)
    {
        Console.WriteLine("Sending Message");
    }
}
