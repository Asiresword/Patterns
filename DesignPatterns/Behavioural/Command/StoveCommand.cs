using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Command
{
    class StoveCommand : ICommand
    {
        private GasStove stove { get; set; }
        public StoveCommand(GasStove stove)
        {
            this.stove = stove;
        }
        public StoveCommand() : this(new GasStove()) { }

        public void Execute()
        {
            this.stove.StartGas();
            this.stove.LightGas();
        }

        public void Undo()
        {
            this.stove.StopStove();
        }
    }
}
