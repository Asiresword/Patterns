using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Factory
{
    public class NissanCar : Car
    {
        private string _Manufacturer { get; }
        private string _Model { get; set; }
        public NissanCar(string m)
        {
            this._Manufacturer = "Toyota";
            this._Model = m;
        }
        public override string Manufacturer
        {
            get { return _Manufacturer; }
        }
        public override string Model
        {
            get { return _Model; }
            set => _Model = value;
        }
    }
}
