using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade.EX;

public class Demo
{
    public static void show()
    {
       var api = new TwitterApi("appKey", "secret");
        api.getRecentTweets();
    }
}
