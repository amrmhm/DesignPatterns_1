using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Design_Patterns.Decorator.EX;

public class Artefact : AbstractArtefact
{
    private string name;

   public Artefact(string name)
    {
        this.name = name;
    }

    public string render()
    {
        
     return name;

    }

   

}
