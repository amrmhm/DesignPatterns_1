using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade.EX;

public class TwitterClient
{
    public List<Tweet> getRecentTweets(string accessToken)
    {
        Console.WriteLine("Getting recent tweets");

        return new List<Tweet>();
    }
}

