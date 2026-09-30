using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Template;

public abstract class Task
{
    private AuditTrial AuditTrial;
    protected Task()
    {
        AuditTrial = new AuditTrial();
    }

    protected Task(AuditTrial auditTrial)
    {
        AuditTrial = auditTrial;
    }

    public void execute()
    {
        AuditTrial.record();
        doExecute();
    }
    protected abstract void doExecute();
}
