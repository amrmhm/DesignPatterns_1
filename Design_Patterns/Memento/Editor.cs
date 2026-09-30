using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Memento;

public class Editor
{
    private string Content;
    public EditorState CreateState()
    {
        return new EditorState(Content);
    }

    public void restoreState(EditorState state)
    {
        Content = state.getEditorState();
    }

    public string getContent()
    {
        return Content;
    }

    public void setContent(string content)
    {
        Content = content;
    }
}
