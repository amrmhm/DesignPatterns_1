using Design_Patterns.Builder.EX.Html;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder.EX;

public class HtmlDocumentBuilder : DocumentsBuilder
{
    private HtmlDocument document = new HtmlDocument();
    public void addImage(Image image)
    {
        document.add(new HtmlImage(image.getSource()));
    }

    public void addText(Text text)
    {
        document.add(new HtmlParagraph(text.getContent()));

    }

    public string getResult()
    {
        return document.ToString();
    }
}
