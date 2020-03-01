using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Iterator
{
    public class WarehouseNumerator : IProductIterator
    {
        private int Index { get; set; }
        private IProductNumerable Warehouse { get; set; }

        public WarehouseNumerator(IProductNumerable Ware)
        {
            this.Warehouse = Ware;
        }

        public bool HasNext() => Index < Warehouse.Count;

        public Product Next() => Warehouse[Index++];
    }
}
