using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.AbstractFactory
{
    public class AMDCPU : CPU
    {
        private string Model { get; set; }
        public AMDCPU(string m)
        {
            this.Model = m;
        }
        public AMDCPU() : this("Ryzen") { }
        public override string GetInfo()
        {
            return "AMD " + this.Model + " CPU";
        }
    }
}
