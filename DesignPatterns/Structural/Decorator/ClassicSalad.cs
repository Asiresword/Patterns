using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Decorator
{
    public class ClassicSalad : Salad
    {
        public ClassicSalad(string Name) : base(Name) { }
        public ClassicSalad() : this("Classic salad") { }

        public override int GetCost()
        {
            return 10;
        }
    }
}
