using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Decorator
{
    public class PepperSalad : SaladDecorator
    {
        public PepperSalad(Salad salad) : base(salad.Name + ", with pepper", salad) { }

        public override int GetCost()
        {
            return salad.GetCost() + 4;
        }
    }
}
