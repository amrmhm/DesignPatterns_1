using Design_Patterns.Builder.EX.Html;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder.EX;

public interface DocumentsBuilder
{
    void addText(Text text);

    void addImage(Image image);
    string getResult();


}
