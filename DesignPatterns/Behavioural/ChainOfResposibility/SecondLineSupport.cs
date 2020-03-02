using System;

namespace Patterns.DesignPatterns.Behavioural.ChainOfResposibility
{
    public class SecondLineSupport : TechSupport
    {
        public override void Handle(TechClient Client)
        {
            if (Client.SecondLine)
            {
                Console.WriteLine("Second line tech support!");
            }
            else if (this.NextHandler != null)
            {
                this.NextHandler.Handle(Client);
            }
            else
            {
                Console.WriteLine("No one can help this client.");
            }
        }
    }
}
