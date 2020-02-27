using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Factory
{
    public class ToyotaFactory : CarFactory
    {
        private readonly string _Model;
        public ToyotaFactory(string m)
        {
            this._Model = m;
        }

        public override Car CreateCar()
        {
            return new ToyotaCar(this._Model);
        }
    }
}
