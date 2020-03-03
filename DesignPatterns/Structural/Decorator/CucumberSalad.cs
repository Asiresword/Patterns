using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Decorator
{
    public class CucumberSalad : SaladDecorator
    {
        public CucumberSalad(Salad salad) : base(salad.Name + ", with cucumbers", salad) { }

        public override int GetCost()
        {
            return salad.GetCost() + 2;
        }
    }
}
