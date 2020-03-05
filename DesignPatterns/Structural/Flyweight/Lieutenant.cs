using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Flyweight
{
    public class Lieutenant : Soldier
    {
        public Lieutenant()
        {
            this.Name = "Lieutenant";
            this.Weight = 75;
            this.Height = 180;
        }
    }
}
