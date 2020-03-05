using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Flyweight
{
    public class Sergeant : Soldier
    {
        public Sergeant()
        {
            this.Name = "Sergeant";
            this.Weight = 80;
            this.Height = 180;
        }
    }
}
