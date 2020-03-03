using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Memento
{
    public class PlayerMemento
    {
        public string VerticalStep { get; set; }
        public string HorizontalStep { get; set; }

        public PlayerMemento(string H, string V)
        {
            this.HorizontalStep = H;
            this.VerticalStep = V;
        }
    }
}
