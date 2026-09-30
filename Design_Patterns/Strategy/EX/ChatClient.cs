using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy.EX;

public class ChatClient
{
    private EncryptionAlgorithm encryptionAlgorithm;

    public ChatClient(EncryptionAlgorithm encryptionAlgorithm)
    {
        this.encryptionAlgorithm = encryptionAlgorithm;
    }

    public void send(string message)
    {
       var encryptedMessage = encryptionAlgorithm.encrypt(message);
        Console.WriteLine("Sending the encrypted message...");

    }
}
