using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Chain_Of_Responsbility;

public class HttpRequest
{
    private string UserName;
    private string Password;


    public HttpRequest(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }

    public string getUserName()
    {
        return UserName;
    }

    public string getPassword()
    {
        return Password;
    }

}
