using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Visitor
{
    public class Foreman : IVisitor
    {
        public void VisitMas(Mason Mas)
        {
            Console.WriteLine($"[Foreman]: visiting {Mas.Name}");
        }

        public void VisitWelder(Welder Weld)
        {
            Console.WriteLine($"[Foreman]: visiting {Weld.Name}");
        }
    }
}
