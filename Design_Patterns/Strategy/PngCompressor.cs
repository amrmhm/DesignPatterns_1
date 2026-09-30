using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy;

public class PngCompressor : Compressor
{
    public void Compress(string fileName)
    {
        Console.WriteLine("Comperassor Using Png");

    }
}
