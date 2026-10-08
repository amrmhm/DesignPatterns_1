using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade;

public class NotificationServices
{
    public void Send (string message , string target)
    {
        var server = new NotificationServer();
        var connection = server.connection("IpAddress");
        var authToken = server.authention("AppId", "Key");
        server.send(authToken, new Message(message), target);
        connection.disConnect();

    }
}
