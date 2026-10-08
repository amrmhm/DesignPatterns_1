using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Proxy.EX;

public class ProxyProduct : Product
{
    private DbContext dbContext;

    public ProxyProduct(DbContext dbContext, int id) : base(id)
    {
        this.dbContext = dbContext;
    }
    public override void setName(string name)
    {
        base.setName(name);
        dbContext.markAsChanged(this);
    }

   
}
