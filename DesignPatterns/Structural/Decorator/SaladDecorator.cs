using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Decorator
{
    public abstract class SaladDecorator : Salad
    {
        protected Salad salad { get; set; }
        public SaladDecorator(string Name, Salad salad) : base(Name)
        {
            this.salad = salad;
        }
    }
}
