using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Proxy
{
    public class PartStore : IPartGetter
    {
        private List<Part> Parts { get; set; }
        
        public PartStore()
        {
            this.Parts = new List<Part>()
            {
                new Part() { Name = "Car part1", Description = "Sample car part1"},
                new Part() { Name = "Car part2", Description = "Sample car part2"},
                new Part() { Name = "Computer part1", Description = "Sample computer part1"},
                new Part() { Name = "Computer part2", Description = "Sample computer part2"},
            };
        }

        public Part GetPartByName(string Name)
        {
            return this.Parts.Where(p => p.Name == Name).FirstOrDefault();
        }

        public void Dispose() { }
    }
}
