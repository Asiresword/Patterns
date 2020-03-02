using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.ChainOfResposibility
{
    public interface IHandler
    {
        void AddChain(IHandler Handler);
        void Handle(TechClient Client);
    }
}
