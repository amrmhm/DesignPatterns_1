using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns;

public  class Account
{

    private float Balance;
    
    public float deposit(float amount)
    {
        this.Balance += amount;
        return this.Balance;
    }

    public float withdrow(float amount)
    {
        this.Balance -= amount;
        return this.Balance;
    }
    public float getBalance()
    {

        return this.Balance;
    }
}
