using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy;

public class JpegCompressor : Compressor
{
    public void Compress(string fileName)
    {
            Console.WriteLine("Comperassor Using JPEG");

    }
}
