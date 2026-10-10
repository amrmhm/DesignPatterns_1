using Design_Patterns.Builder.EX.Html;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;

namespace Design_Patterns.Builder.EX;

public class Document
{
    private List<Element> elements = new List<Element>();

    public void add(Element element)
    {
        elements.Add(element);
    }

    public void export(DocumentsBuilder builder, string fileName) 
    {
        string content = "";
        foreach(var element in elements)
        {
            if (element is Text)
                builder.addText((Text)element);
            else if (element is Image)
                builder.addImage((Image)element);
        }
        content = builder.getResult();



        File.WriteAllText(fileName, content);
    }
}
