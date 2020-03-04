using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Adapter
{
    public class Driver
    {
        private ITransport Transport { get; set; }
        public Driver(ITransport Transport)
        {
            this.Transport = Transport;
        }

        public void SetTransport(ITransport Transport)
        {
            this.Transport = Transport;
        }

        public void StartRide()
        {
            this.Transport.Drive();
        }
    }
}
