using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Decorator
{
    public abstract class Salad
    {
        public string Name { get; protected set; }
        public Salad(string Name)
        {
            this.Name = Name;
        }
        public Salad() : this("Salad") { }

        public abstract int GetCost();
    }
}
