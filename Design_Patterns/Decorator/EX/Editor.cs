using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Decorator.EX;

public class Editor
{
    public void openProject(String path)
    {
        AbstractArtefact[] artefacts = {
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider"),
        };

        artefacts[0] = new MainDecorator(artefacts[0]);
        artefacts[1] = new ErrorDecorator(new MainDecorator(artefacts[1]));
        artefacts[2] = new ErrorDecorator(artefacts[2]);

        foreach (var artefact in artefacts)
            Console.WriteLine(artefact.render());
    }
}
