using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Visitor
{
    public class Welder : IWorker
    {
        public string Name { get; set; }
        public Welder()
        {
            this.Name = "Welder";
        }
        public void Accept(IVisitor Visitor)
        {
            Visitor.VisitWelder(this);
        }
    }
}
