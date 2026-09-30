using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Memento;

public class EditorState
{
    private readonly string Content;
    public EditorState(string content)
    {
        Content = content;
    }

    public string getEditorState()
    {
        return Content;
    }
}
