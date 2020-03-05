using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Proxy
{
    public class PartStoreProxy : IPartGetter
    {
        private List<Part> Parts { get; set; } = null;
        private PartStore Store { get; set; } = null;

        public PartStoreProxy()
        {
            this.Parts = new List<Part>();
        }

        public Part GetPartByName(string Name)
        {
            Part NamedPart = this.Parts.Where(p => p.Name == Name).FirstOrDefault();

            if(NamedPart == null)
            {
                if(this.Store == null)
                {
                    this.Store = new PartStore();
                }
                NamedPart = Store.GetPartByName(Name);
                this.Parts.Add(NamedPart);
            }

            return NamedPart;
        }

        public void Dispose() { }
    }
}
