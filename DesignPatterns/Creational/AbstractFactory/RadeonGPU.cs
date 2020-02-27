using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.AbstractFactory
{
    public class RadeonGPU : GPU
    {
        private string Model { get; set; }
        public RadeonGPU(string m)
        {
            this.Model = m;
        }
        public RadeonGPU() : this("RX") { }
        public override string GetInfo()
        {
            return "Radeon " + this.Model + " GPU";
        }
    }
}
