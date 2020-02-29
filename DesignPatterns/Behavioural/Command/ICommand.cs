using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
