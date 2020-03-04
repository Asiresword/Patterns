using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Composite
{
    public class File : Component
    {
        protected override string Name { get; set; }
        public File(string Name) : base(Name) { }

        public override void PrintComponent(int Tabs = 0)
        {
            Console.WriteLine(new string('\t', Tabs) + "Leaf: " + this.Name);
        }
    }
}
