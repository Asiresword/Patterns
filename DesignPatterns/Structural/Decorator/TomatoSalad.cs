using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Decorator
{
    public class TomatoSalad : SaladDecorator
    {
        public TomatoSalad(Salad salad) : base(salad.Name + ", with tomatoes", salad) { }

        public override int GetCost()
        {
            return salad.GetCost() + 3;
        }
    }
}
