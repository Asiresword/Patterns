using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Builder
{
    public class Bed
    {
        public string Carcass { get; set; }
        public string Mattress { get; set; }
        public string Blanket { get; set; }
        public string[] Pillows { get; set; }

        public override string ToString()
        {
            string Pill = "";
            foreach (string Pillow in Pillows)
            {
                Pill += $"{Pillow} ";
            }
            return $"Bed: Carcass: {this.Carcass} |  Mattress: {this.Mattress} | \n\tPillows: {Pill} | Blanket: {this.Blanket}";
        }
    }
}
