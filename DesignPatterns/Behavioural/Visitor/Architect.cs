using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Visitor
{
    public class Architect : IVisitor
    {
        public void VisitMas(Mason Mas)
        {
            Console.WriteLine($"[Architect]: visiting {Mas.Name}");
        }

        public void VisitWelder(Welder Weld)
        {
            Console.WriteLine($"[Architect]: visiting {Weld.Name}");
        }
    }
}
