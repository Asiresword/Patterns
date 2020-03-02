using System;

namespace Patterns.DesignPatterns.Behavioural.ChainOfResposibility
{
    public class FirstLineSupport : TechSupport
    {
        public override void Handle(TechClient Client)
        {
            if(Client.FirstLine)
            {
                Console.WriteLine("First line tech support!");
            }
            else if(this.NextHandler != null)
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
