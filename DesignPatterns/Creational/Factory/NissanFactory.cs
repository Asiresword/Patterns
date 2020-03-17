using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Factory
{
    public class NissanFactory : CarFactory
    {
        private readonly string _Model;
        public NissanFactory(string m)
        {
            this._Model = m;
        }

        public override Car CreateCar()
        {
            return new NissanCar(this._Model);
        }
    }
}
