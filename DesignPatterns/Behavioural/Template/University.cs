using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Template
{
    public class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Entering university.");
        }

        public override void Study()
        {
            Console.WriteLine("Studying university material.");
        }

        public override void Examine()
        {
            Console.WriteLine("Passing university exam.");
        }
    }
}
