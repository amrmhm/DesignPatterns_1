using Design_Patterns.FactoryMethod.Matcha;
using Design_Patterns.FactoryMethod.Sharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.FactoryMethod;

public class ProductController : Controller
{
    public void ListProduct()
    {
        //Get Product from db 
        Dictionary<string , object> context = new Dictionary<string, object>();
        //Add Product To context
        //context["key"] = "value";

        Render("product.html", context );

    }
}
