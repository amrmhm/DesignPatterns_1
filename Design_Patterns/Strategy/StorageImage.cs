using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Strategy;

public class StorageImage
{
    //private Compressor Comperassor;
    //private Filter Filter;


    //public StorageImage(Compressor comperassor, Filter filter)
    //{
    //    this.Comperassor = comperassor;
    //    this.Filter = filter;
    //}

    //public void store (string fileName)
    //{

    //    Comperassor.Compress(fileName);
    //    Filter.Apply(fileName);
        
    //}

    //Or


    public void store (string fileName , Compressor compressor , Filter filter)
    {

        compressor.Compress(fileName);
        filter.Apply(fileName);
        
    }
}
