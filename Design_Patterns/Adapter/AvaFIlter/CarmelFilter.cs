using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Adapter.AvaFIlter;

public class CarmelFilter : Filter
{
    private Carmel carmel;

    public CarmelFilter(Carmel carmel)
    {
        this.carmel = carmel;
    }

    public void apply(Image image)
    {
        carmel.init();
        carmel.render(image);
    }
}
