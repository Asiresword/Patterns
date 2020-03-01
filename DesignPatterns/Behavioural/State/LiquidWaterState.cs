using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.State
{
    public class LiquidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Water becomes gas");
            water.SetState(new GasWaterState());
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Water becomes ice");
            water.SetState(new SolidWaterState());
        }
    }
}
