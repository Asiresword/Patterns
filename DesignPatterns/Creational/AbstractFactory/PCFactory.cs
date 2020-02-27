using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.AbstractFactory
{
    public abstract class PCFactory
    {
        public abstract CPU CreateCPU();
        public abstract GPU CreateGPU();
    }
}
