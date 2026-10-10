using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.FactoryMethod.Matcha;

public class Conttroller
{
    public void Render(string viewName , Dictionary<string , object> contrxt )
    {
        var engine = createViewEngine();
        var html = engine.Render(viewName, contrxt);
        Console.WriteLine(html);

    }
   protected virtual ViewEngine createViewEngine ()
    {
        return new MatchaViewEngine();
    }
}
