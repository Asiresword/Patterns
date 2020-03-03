using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Decorator
{
    public class DietSalad : Salad
    {
        public DietSalad(string Name) : base(Name) { } 
        public DietSalad() : this("Diet salad") { }

        public override int GetCost()
        {
            return 5;
        }
    }
}
