using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Bridge;

public  class RemoteControl
{
    protected Device device;

    public RemoteControl(Device device)
    {
        this.device = device;
    }

    public  void TrunOff()
    {
        device.TrunOff();
    }
    public  void TrunOn()
    {
        device.TrunOn();
    }
}
