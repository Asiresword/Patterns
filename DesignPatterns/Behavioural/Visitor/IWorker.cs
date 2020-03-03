using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Visitor
{
    public interface IWorker
    {
        void Accept(IVisitor Visitor);
    }
}
