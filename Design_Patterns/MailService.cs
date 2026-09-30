using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns;

public class MailService
{
    public void SendMail()
    {
        Connect(1);
        Authenticate();
        //SendMail 
        Disconnect();
    }
    private void Connect(int timeout)
    {
        Console.WriteLine("Connecting to mail server...");
    }

    private void Disconnect() 
    { 
        Console.WriteLine("Disconnecting from mail server...");
    }
    private void Authenticate()
    {
        Console.WriteLine("Authenticating with mail server...");
    }

}
