using Design_Patterns.Adapter.EX.Gmail;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Adapter.EX;

public class GmailAdaptee : EmailProvider
{
    private GmailClient gmailClient;

    public GmailAdaptee(GmailClient gmailClient)
    {
        this.gmailClient = gmailClient;
    }

    public void downloadEmails()
    {
        gmailClient.connect();
        gmailClient.getEmails();
        gmailClient.disconnect();
    }
}
