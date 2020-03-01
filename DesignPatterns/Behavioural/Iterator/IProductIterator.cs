using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Iterator
{
    public interface IProductIterator
    {
        bool HasNext();
        Product Next();
    }
}
