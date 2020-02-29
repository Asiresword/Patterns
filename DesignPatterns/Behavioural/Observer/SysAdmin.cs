using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Observer
{
    public class SysAdmin : IObserver
    {
        private IObservable Server { get; set; }

        public SysAdmin(IObservable Server)
        {
            this.Server = Server;
            this.Server.RegisterObserver(this);
        }

        public void Update(object Target)
        {
            ServerInfo Info = Target as ServerInfo;

            Console.WriteLine("[Admin]: " + (Info.IsDown == true ? "Gonna get the server up" : "Nothing to do here"));
        }

        public void StartListening(IObservable Server)
        {
            if (this.Server != null)
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
