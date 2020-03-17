using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Factory
{
    public class ToyotaCar : Car
    {
        private string _Manufacturer { get; }
        private string _Model { get; set; }
        public ToyotaCar(string m) {
            this._Manufacturer = "Toyota";
            this._Model = m;
        }
        public override string Manufacturer
        {
            get { return _Manufacturer; }
        }
        public override string Model { 
            get { return $"Toyota {_Model}"; }
            set => _Model = value;
        }
    }
}
