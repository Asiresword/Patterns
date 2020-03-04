using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Adapter
{
    public class Horse : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Riding by a horse.");
        }
    }
}
