using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Memento
{
    public class PlayerHistory
    {
        public Stack<PlayerMemento> History { get; set; }
        public PlayerHistory()
        {
            this.History = new Stack<PlayerMemento>();
        }
    }
}
