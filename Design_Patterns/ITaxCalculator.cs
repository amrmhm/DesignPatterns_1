using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns;

public interface ITaxCalculator
{
    public float CalculatorTax();
    public float CalculatorDiscount();
}
