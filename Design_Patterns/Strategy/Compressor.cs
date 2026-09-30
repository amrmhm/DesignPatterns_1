using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy;

public interface Compressor
{
    public void Compress(string fileName);
}
