using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Design_Patterns.Flyweight.EX;

public class CellContextFactory
{
    private Dictionary<int, CellContext> contexts = new Dictionary<int, CellContext>();

    public CellContext getContext(string fontFamily, int fontSize, bool isBold)
    {
        // Generate a unique key for the combination of fontFamily, fontSize and isBold attributes.
        var hash = HashCode.Combine(fontFamily, fontSize, isBold);

        if (!contexts.ContainsKey(hash))
            contexts.Add(hash , new CellContext(fontFamily, fontSize, isBold));

        return contexts[hash];
    }
}
