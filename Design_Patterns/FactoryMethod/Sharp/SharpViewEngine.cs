using Design_Patterns.FactoryMethod.Matcha;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.FactoryMethod.Sharp;

public class SharpViewEngine : ViewEngine
{
    public string Render(string ViewName, Dictionary<string, object> context)
    {
       
        return "Sharp View Engine";
    }
}
