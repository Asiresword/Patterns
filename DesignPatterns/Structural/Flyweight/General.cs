using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Flyweight
{
    class General : Soldier
    {
        public General()
        {
            this.Name = "General";
            this.Weight = 75;
            this.Height = 175;
        }
    }
}
