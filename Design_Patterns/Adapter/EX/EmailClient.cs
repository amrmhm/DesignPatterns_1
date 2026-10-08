using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Adapter.EX;

public class EmailClient
{
    private List<EmailProvider> providers = new List<EmailProvider>(); 
    public void addProvider(EmailProvider provider)
    {
        
        providers.Add(provider);
    }

    public void downloadEmails()
    {
        foreach (var provider in providers)
            provider.downloadEmails();
    }
}
