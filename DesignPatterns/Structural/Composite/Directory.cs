using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Composite
{
    public class Directory : Component
    {
        protected override string Name { get; set; }
        private List<Component> Components { get; set; }
        public Directory(string Name) : base(Name) 
        {
            this.Components = new List<Component>();
        }

        public override void Add(Component component)
        {
            this.Components.Add(component);
        }

        public override void Remove(Component component)
        {
            this.Components.Remove(component);
        }

        public override void PrintComponent(int Tabs = 0)
        {
            Console.WriteLine(new string('\t', Tabs) + "Composite: " + this.Name);
            Console.WriteLine(new string('\t', Tabs) + "Components: ");
            foreach (Component component in Components)
            {
                component.PrintComponent(Tabs + 1);
            }
        }
    }
}
