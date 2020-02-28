using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Singleton
{
    public class Company
    {
        private Director director { get; set; }
        public Company()
        {
            this.director = Director.GetInstance();
        }

        public string GetDirectorName() => director.Name;
        public void SetDirectorName(string Name) => this.director.Name = Name;
    }
}
