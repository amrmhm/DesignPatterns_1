using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Adapter;

public class ViewFilter 
{
    private Image Image;

    public ViewFilter(Image images)
    {
        Image = images;
    }

    public void apply (Filter filter)
    {
        filter.apply(Image);
    }
}
