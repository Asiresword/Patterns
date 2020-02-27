using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.AbstractFactory
{
    public class NVIDIAGPU : GPU
    {
        private string Model { get; set; }
        public NVIDIAGPU(string m)
        {
            this.Model = m;
        }
        public NVIDIAGPU() : this("GTX") { }
        public override string GetInfo()
        {
            return "NVIDIA " + this.Model + " GPU";
        }
    }
}
