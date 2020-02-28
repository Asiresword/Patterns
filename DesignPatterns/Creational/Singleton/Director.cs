using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Singleton
{
    public class Director
    {
        private static readonly Lazy<Director> director =
                                new Lazy<Director>(() => new Director());

        public string Name { get; set; }

        private Director()
        {
            this.Name = "%Director_Name%";
        }

        public static Director GetInstance() => director.Value;
    }
}
