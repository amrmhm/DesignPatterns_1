using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator.EX;

public class MainDecorator : AbstractArtefact
{
    private AbstractArtefact artefact;


    public MainDecorator(AbstractArtefact artefact)
    {
        this.artefact = artefact;
    }

    public string render()
    {
        
        return artefact.render() + "[Main]";

    }


}
