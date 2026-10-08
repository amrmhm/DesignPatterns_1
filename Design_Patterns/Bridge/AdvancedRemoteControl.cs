using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Bridge;

public  class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(Device device) : base(device)
    {
        
    }
    public  void SetChannel(int number)
    {
        device.SetChannel(number);
    }
}
