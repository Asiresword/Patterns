using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Observer
{
    public interface IObservable
    {
        void RegisterObserver(IObserver Observer);
        void RemoveObserver(IObserver Observer);
        void NotifyObservers();
    }
}
