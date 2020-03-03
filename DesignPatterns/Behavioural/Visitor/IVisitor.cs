using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Visitor
{
    public interface IVisitor
    {
        void VisitWelder(Welder Weld);
        void VisitMas(Mason Mas);
    }
}
