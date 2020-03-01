using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.State
{
    public class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Water becomes liquid");
            water.SetState(new LiquidWaterState());
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Nothing happens");
        }
    }
}
