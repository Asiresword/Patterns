using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Builder
{
    public class RichBedBuilder : IBedBuilder
    {
        private Bed bed;

        public void AddCarcass()
        {
            bed.Carcass = "Big wooden carcass";
        }

        public void AddMattress()
        {
            bed.Mattress = "Soft mattress";
        }

        public void AddPillows()
        {
            bed.Pillows = new string[] { "Rich red pillow", "Rich white pillow" };
        }

        public void AddBlanket()
        {
            bed.Blanket = "Silk blanket";
        }

        public Bed GetBed()
        {
            return this.bed;
        }

        public void Clear()
        {
            this.bed = new Bed();
        }
    }
}
