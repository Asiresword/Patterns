using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Observer
{
    public class Client : IObserver
    {
        private IObservable Server { get; set; } = null;

        public Client(IObservable Server)
        {
            this.Server = Server;
            this.Server.RegisterObserver(this);
        }

        public void Update(object Target)
        {
            ServerInfo Info = Target as ServerInfo;

            Console.WriteLine("[Client]: " + (Info.IsDown == true ? "Nothing to do here" : "Making actions"));
        }

        public void StartListening(IObservable Server)
        {
            if(this.Server != null)
            {
                StopListening();
            }

            this.Server = Server;
        }

        public void StopListening()
        {
            this.Server.RemoveObserver(this);
            this.Server = null;
        }
    }
}
