using Design_Patterns.FactoryMethod.Matcha;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.FactoryMethod.Sharp;

public class Controller : Conttroller
{
    protected override ViewEngine createViewEngine()
    {
        return new SharpViewEngine();
    }
}
