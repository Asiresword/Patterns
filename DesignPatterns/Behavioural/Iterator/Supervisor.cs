using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Iterator
{
    public class Supervisor
    {
        public void SeeProducts(Warehouse warehouse)
        {
            IProductIterator iterator = warehouse.CreateNumerator();
            while (iterator.HasNext())
            {
                Product product = iterator.Next();
                Console.WriteLine(product.Name);
            }
        }
    }
}
