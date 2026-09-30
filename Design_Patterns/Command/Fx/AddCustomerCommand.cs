using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.Fx;

public class AddCustomerCommand : Command
{
    public CustomerServices Services;

    public AddCustomerCommand(CustomerServices services)
    {
        Services = services;
    }

    public void execute()
    {
        Services.AddCustomer();
    }
}
