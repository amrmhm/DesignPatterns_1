using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder.EX;

public class TextDocumentBuilder : DocumentsBuilder
{
    private StringBuilder builder = new StringBuilder();
    public void addImage(Image image)
    {
        
    }

    public void addText(Text text)
    {
        builder.Append(text.getContent());
    }

    public string getResult()
    {
      return builder.ToString();
    }
}
