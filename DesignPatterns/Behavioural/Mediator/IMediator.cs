using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Mediator
{
    public interface IMediator
    {
        void Send(string Message, JewelryActor Actor);
    }
}
