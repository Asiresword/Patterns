using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Visitor
{
    public class Mason : IWorker
    {
        public string Name { get; set; }
        public Mason()
        {
            this.Name = "Mason";
        }
        public void Accept(IVisitor Visitor)
        {
            Visitor.VisitMas(this);
        }
    }
}
