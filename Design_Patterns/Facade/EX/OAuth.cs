using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade.EX;

public class OAuth
{
        public string requestToken(string appKey, string appSecret)
        {
        Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public string getAccessToken(string requestToken)
        {
        Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }

