using System;

namespace Patterns.DesignPatterns.Behavioural.ChainOfResposibility
{
    public class ThirdLineSupport : TechSupport
    {
        public override void Handle(TechClient Client)
        {
            if (Client.ThirdLine)
            {
                Console.WriteLine("Third line tech support!");
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
