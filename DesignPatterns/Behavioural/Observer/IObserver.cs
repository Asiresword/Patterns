using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Observer
{
    public interface IObserver
    {
        void Update(object Target);
        void StartListening(IObservable Server);
        void StopListening();
    }
}
