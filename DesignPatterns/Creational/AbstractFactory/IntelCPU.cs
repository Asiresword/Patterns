using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.AbstractFactory
{
    public class IntelCPU : CPU
    {
        private string Model { get; set; }
        public IntelCPU(string m)
        {
            this.Model = m;
        }
        public IntelCPU() : this("Xeon") { }
        public override string GetInfo()
        {
            return "Intel " + this.Model + " CPU";
        }
    }
}
