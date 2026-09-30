using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Iterator.EX;
    public class Product
    {
        private int id;
        private string name;

        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        override
  public string ToString()
        {
            return "Product{" +
                    "id=" + id +
                    ", name='" + name + '\'' +
                    '}';
        }
    }

