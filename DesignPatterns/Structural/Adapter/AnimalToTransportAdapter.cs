using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Adapter
{
    public class AnimalToTransportAdapter : ITransport
    {
        private IAnimal Animal { get; set; }
        public AnimalToTransportAdapter(IAnimal Animal)
        {
            this.Animal = Animal;
        }

        public void Drive()
        {
            Animal.Move();
        }
    }
}
