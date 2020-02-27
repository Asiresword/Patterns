using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.AbstractFactory
{
    public class PC
    {
        private CPU Processor { get; set; }
        private GPU Graphical { get; set; }
        public PC(PCFactory Factory)
        {
            this.Processor = Factory.CreateCPU();
            this.Graphical = Factory.CreateGPU();
        }

        public string CPUInfo()
        {
            return this.Processor.GetInfo();
        }

        public string GPUInfo()
        {
            return this.Graphical.GetInfo();
        }
    }
}
