using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Mediator
{
    public class JewelryCustomer : JewelryActor
    {
        public JewelryCustomer(IMediator Mediator) : base(Mediator) { }
        public override void Notify(string Message)
        {
            Console.WriteLine($"Message to customer: {Message}");
        }
    }
}
