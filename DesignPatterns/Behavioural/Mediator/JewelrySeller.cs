using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Mediator
{
    public class JewelrySeller : JewelryActor
    {
        public JewelrySeller(IMediator Mediator) : base(Mediator) { }
        public override void Notify(string Message)
        {
            Console.WriteLine($"Message to seller: {Message}");
        }
    }
}
