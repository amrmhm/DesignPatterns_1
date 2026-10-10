using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Builder;

public interface PresentionBuilder
{
    public void addSlide(Slide slide);
}
