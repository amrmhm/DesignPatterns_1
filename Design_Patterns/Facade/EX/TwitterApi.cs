using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade.EX;

public class TwitterApi
{
    private string AppKey;
    private string Secret;


    public TwitterApi(string appKey, string secret)
    {
        AppKey = appKey;
        Secret = secret;
    }




    public List<Tweet> getRecentTweets()
    {
        var twitterClient = new TwitterClient();
        var tweets = twitterClient.getRecentTweets(getAccessToken());

        return tweets;
    }

    private string getAccessToken()
    {
        var oauth = new OAuth();
        var requestToken = oauth.requestToken(AppKey, Secret);
        var accessToken = oauth.getAccessToken(requestToken);

        return accessToken;
    }
}
