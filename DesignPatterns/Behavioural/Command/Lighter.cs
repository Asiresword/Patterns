using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Command
{
    public class Lighter
    {
        private ICommand Command { get; set; }
        public Lighter() { }
        public Lighter(ICommand Command) 
        {
            SetCommand(Command);
        }

        public void SetCommand(ICommand Command)
        {
            this.Command = Command;
        }

        public void Lit()
        {
            this.Command.Execute();
        }
        public void StopLighter()
        {
            this.Command.Undo();
        }
    }
}
