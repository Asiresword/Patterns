using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Flyweight
{
    public abstract class Soldier
    {
        protected string Name { get; set; }
        protected double Weight { get; set; }
        protected double Height { get; set; }

        public virtual string GetInfo()
        {
            return String.Format("[{0}]: {1}, {2}", this.Name, this.Weight, this.Height);
        }
    }
}
