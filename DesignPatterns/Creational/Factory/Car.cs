using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Factory
{
    public abstract class Car
    {
        public abstract string Manufacturer { get; }
        public abstract string Model { get; set; }
    }
}
