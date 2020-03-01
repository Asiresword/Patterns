using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Template
{
    public class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Entering school.");
        }

        public override void Study()
        {
            Console.WriteLine("Studying school material.");
        }

        public override void Examine()
        {
            Console.WriteLine("Passing school exam.");
        }
    }
}
