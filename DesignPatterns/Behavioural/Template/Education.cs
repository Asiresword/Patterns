using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Template
{
    public abstract class Education
    {
        public virtual void Start()
        {
            Enter();
            Study();
            Examine();
            Certificate();
        }
        public abstract void Enter();
        public abstract void Study();
        public abstract void Examine();
        public virtual void Certificate()
        {
            Console.WriteLine("Getting certificate");
        }
    }
}
