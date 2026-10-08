using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator;

public class CompresedCloudStream :   Streams
{
    private Streams Stream;

    public CompresedCloudStream(Streams stream)
    {
        Stream = stream;
    }

    public  void write(string data)
    {
        var compressed = compress(data);
        Stream.write(compressed);
    }

    private string compress(string data)
    {
        return data.Substring(0,4);
    }
}
