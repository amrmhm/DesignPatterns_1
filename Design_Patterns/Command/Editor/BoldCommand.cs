using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Command.Editor;

public class BoldCommand : UndoableCommand
{
    private string prevContent;

    private History History;

    private HtmlDocument Document;


    public BoldCommand(History history, HtmlDocument document)
    {
        History = history;
        Document = document;
    }

    public void execute()
    {
        prevContent = Document.getContent();
        Document.BoldContent();
        History.push(this);
    }

    public void unexecute()
    {
        Document.setContent(prevContent);
    }
}

    
