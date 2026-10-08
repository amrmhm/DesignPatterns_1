using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Bridge;

public  interface Device
{
    public  void TrunOff();
    public void TrunOn();
    public void SetChannel(int number);
}
