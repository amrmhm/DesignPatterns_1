using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator;

public class EncryeptedCloudStream : Streams
{
    private Streams Stream;

    public EncryeptedCloudStream(Streams stream)
    {
        Stream = stream;
    }
    public  void write(string data)
    {
        var encrypted = encrypt(data);
        Stream.write(encrypted);
    }
    private string encrypt(string data)
    {
        return "!@#$%^&*())(*&^%$";
    }
}
