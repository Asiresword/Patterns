using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Command
{
    class CigaretteCommand : ICommand
    {
        private Cigarette cigarette { get; set; }
        public CigaretteCommand(Cigarette cigarette)
        {
            this.cigarette = cigarette;
        }
        public CigaretteCommand() : this(new Cigarette()) { }

        public void Execute()
        {
            this.cigarette.StartBurning();
            this.cigarette.StartSmoking();
        }

        public void Undo()
        {
            this.cigarette.PutOut();
        }
    }
}
