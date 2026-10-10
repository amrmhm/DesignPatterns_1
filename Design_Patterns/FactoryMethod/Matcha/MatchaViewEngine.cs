using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.FactoryMethod.Matcha;

public class MatchaViewEngine : ViewEngine
{
    public string Render(string ViewName, Dictionary<string, object> context)
    {
        return "Matcha View Engine";
    }

}
