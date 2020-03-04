using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Adapter
{
    public class Vehicle : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Riding by a vehicle.");
        }
    }
}
