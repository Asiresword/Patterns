using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.ChainOfResposibility
{
    public abstract class TechSupport : IHandler
    {
        protected IHandler NextHandler { get; set; } = null;
        public void AddChain(IHandler Handler)
        {
            NextHandler = Handler;
        }

        public abstract void Handle(TechClient Client);
    }
}
