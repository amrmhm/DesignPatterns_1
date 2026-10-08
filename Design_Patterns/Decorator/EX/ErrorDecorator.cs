using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator.EX;

public class ErrorDecorator : AbstractArtefact
{
    private AbstractArtefact artefact;


    public ErrorDecorator(AbstractArtefact artefact)
    {
        this.artefact = artefact;
    }

    public string render()
    {

        return artefact.render() + "[Error]";

    }
}
