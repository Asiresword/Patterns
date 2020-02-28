using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Creational.Builder
{
    public class BedCarpenter
    {
        private IBedBuilder builder { get; set; }
        public BedCarpenter(IBedBuilder builder)
        {
            AcceptBuilder(builder);
        }
        public BedCarpenter() : this(new PoorBedBuilder()) { }

        public Bed Build()
        {
            builder.AddCarcass();
            builder.AddMattress();
            builder.AddPillows();
            builder.AddBlanket();
            return builder.GetBed();
        }

        public void ChangeBuilder(IBedBuilder builder)
        {
            AcceptBuilder(builder);
        }

        private void AcceptBuilder(IBedBuilder builder)
        {
            this.builder = builder;
            this.builder.Clear();
        }
    }
}
