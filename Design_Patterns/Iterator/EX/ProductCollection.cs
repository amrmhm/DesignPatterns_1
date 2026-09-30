using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Iterator.EX;

public class ProductCollection
{
        private List<Product> products = new List<Product>();

        public void add(Product product)
        {
            products.Add(product);
        }

    public ProductIterator createProduct()
    {
        return new ProductIterator(this);
    }


    public class ProductIterator : Iterator
    {
        private ProductCollection ProductCollection;
        private int index;

        public ProductIterator(ProductCollection productCollection)
        {
            ProductCollection = productCollection;
        }

        public Product current()
        {
            return ProductCollection.products[index];
        }

        public bool hasNext()
        {
            return index < ProductCollection.products.Count;
        }

        public void next()
        {
            index++;
        }
    }

}


