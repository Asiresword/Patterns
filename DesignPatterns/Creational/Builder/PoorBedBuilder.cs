using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Builder
{
    public class PoorBedBuilder : IBedBuilder
    {
        private Bed bed;

        public void AddCarcass()
        {
            bed.Carcass = "Small iron carcass";
        }

        public void AddMattress()
        {
            bed.Mattress = "Hard mattress";
        }

        public void AddPillows()
        {
            bed.Pillows = new string[] { "Poor white pillow" };
        }

        public void AddBlanket()
        {
            bed.Blanket = "Cotton blanket";
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
