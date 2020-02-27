using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.AbstractFactory
{
    public class NIPCFactory : PCFactory
    {
        public override CPU CreateCPU()
        {
            return new IntelCPU();
        }

        public override GPU CreateGPU()
        {
            return new NVIDIAGPU();
        }
    }
}
