using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Composite
{
    public abstract class Component
    {
        protected abstract string Name { get; set; }
        public Component(string Name)
        {
            this.Name = Name;
        }

        public virtual void Add(Component component) {  }
        public virtual void Remove(Component component) {  }

        public virtual void PrintComponent(int Tabs = 0)
        {
            Console.WriteLine(this.Name);
        }
    }
}
