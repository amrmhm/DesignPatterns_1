using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Facade;

public class Message
{
    private string Content;

    public Message(string content)
    {
        Content = content;
    }
}
