using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Iterator
{
    public interface IProductNumerable
    {
        IProductIterator CreateNumerator();
        int Count { get; }
        Product this[int index] { get; }
    }
}
