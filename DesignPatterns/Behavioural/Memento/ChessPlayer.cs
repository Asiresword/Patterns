using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Memento
{
    public class ChessPlayer
    {
        private string VerticalStep { get; set; } // 1 2 3 ...
        private string HorizontalStep { get; set; } // a b c ...

        public void Step(string H, string V)
        {
            this.HorizontalStep = H;
            this.VerticalStep = V;
            Console.WriteLine($"Going on {H}{V}");
        }

        public PlayerMemento SaveMemento()
        {
            Console.WriteLine($"Saving: {this.HorizontalStep}{this.VerticalStep}");
            return new PlayerMemento(this.HorizontalStep, this.VerticalStep);
        }

        public void RestoreMemento(PlayerMemento Memento)
        {
            this.HorizontalStep = Memento.HorizontalStep;
            this.VerticalStep = Memento.VerticalStep;
            Console.WriteLine($"Player step has been restored. Current: {this.HorizontalStep}{this.VerticalStep}");
        }
    }
}
