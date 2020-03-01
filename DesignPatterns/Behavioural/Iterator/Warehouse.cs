using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Iterator
{
    public class Warehouse : IProductNumerable
    {
        private List<Product> Products { get; set; }
        public Warehouse()
        {
            Products = new List<Product>()
            {
                new Product() { Name = "Product1" },
                new Product() { Name = "Product2" },
                new Product() { Name = "Product3" }
            };
        }

        public int Count 
        { 
            get { return Products.Count; }
        }

        public Product this[int index] => Products[index];

        public IProductIterator CreateNumerator()
        {
            return new WarehouseNumerator(this);
        }
    }
}
