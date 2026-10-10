using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder;

public class PdfPresentionBuilder : PresentionBuilder
{
    private PDFDocument PDFDocument = new PDFDocument();
    public void addSlide(Slide slide)
    {
        PDFDocument.addPage(slide.getText());
    }

    public PDFDocument get()
    {
        return PDFDocument;
    }
}
