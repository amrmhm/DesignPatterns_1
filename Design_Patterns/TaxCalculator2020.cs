using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns;

public class TaxCalculator2020 : ITaxCalculator
{
    public float CalculatorDiscount()
    {
        throw new NotImplementedException();
    }

    public float CalculatorTax()
    {
        return 2;
    }
}
