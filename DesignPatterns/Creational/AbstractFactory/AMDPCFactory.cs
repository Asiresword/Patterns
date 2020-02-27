using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.AbstractFactory
{
    public class AMDPCFactory : PCFactory
    {
        public override CPU CreateCPU()
        {
            return new AMDCPU();
        }

        public override GPU CreateGPU()
        {
            return new RadeonGPU();
        }
    }
}
