using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Mediator
{
    public class JewelryMaster : JewelryActor
    {
        public JewelryMaster(IMediator Mediator) : base(Mediator) { }
        public override void Notify(string Message)
        {
            Console.WriteLine($"Message to master: {Message}");
        }
    }
}
