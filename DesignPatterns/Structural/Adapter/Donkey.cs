using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Adapter
{
    public class Donkey : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Riding by a donkey.");
        }
    }
}
