using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Mediator
{
    public abstract class JewelryActor
    {
        protected IMediator Mediator { get; set; }

        public JewelryActor(IMediator Mediator)
        {
            this.Mediator = Mediator;
        }

        public virtual void Send(string Message)
        {
            this.Mediator.Send(Message, this);
        }
        public abstract void Notify(string Message);
    }
}
