using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Visitor
{
    class BuildingCompany
    {
        private List<IWorker> Workers { get; set; }
        public BuildingCompany()
        {
            this.Workers = new List<IWorker>();
        }

        public void Add(IWorker Worker)
        {
            Workers.Add(Worker);
        }

        public void Remove(IWorker Worker)
        {
            Workers.Remove(Worker);
        }

        public void Accept(IVisitor Visitor)
        {
            foreach (IWorker Worker in Workers)
            {
                Worker.Accept(Visitor);
            }
        }
    }
}
