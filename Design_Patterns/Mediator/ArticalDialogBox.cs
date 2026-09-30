using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator;

public class ArticalDialogBox 
{
    private ListBox articalListBox = new ListBox();
    private TextBox titleTextBox = new TextBox();
    private Button button = new Button(); 

    public ArticalDialogBox()
    {
        articalListBox.addObserver(() => { articalSelected(); });
        titleTextBox.addObserver(() => { titleContent(); });
    }




    //public override void changed(UiControl control)
    //{
    //    if (control == articalListBox)
    //        articalSelected();
    //    else if (control == titleTextBox)
    //        titleContent();


    //}

    public void simulateUserInteraction()
    {
        articalListBox.setSelection("Article 1");
        titleTextBox.setContent("New Title");
        //titleTextBox.setContent("");

        Console.WriteLine("TextBox Content: " + titleTextBox.getContent());
        Console.WriteLine("Button Enabled: " + button.getEnable());
    }

    private void titleContent()
    {
        var content = titleTextBox.getContent();
        var isEmpty = (content == null || content.IsWhiteSpace());
        button.setEnabled(!isEmpty);
     }
    private void articalSelected()
    {
        titleTextBox.setContent(articalListBox.getSelection());
        button.setEnabled(true);
    }
}
