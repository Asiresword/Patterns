using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Observer
{
    public class Server : IObservable
    {
        private ServerInfo Info { get; set; }
        private List<IObserver> Observers { get; set; }
        public Server()
        {
            Observers = new List<IObserver>();
            Info = new ServerInfo();
        }

        public void RegisterObserver(IObserver Observer)
        {
            this.Observers.Add(Observer);
        }

        public void RemoveObserver(IObserver Observer)
        {
            this.Observers.Remove(Observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(this.Info);
            }
        }

        public void SetDown(bool status)
        {
            this.Info.IsDown = status;

            NotifyObservers();
        }
    }
}
