using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Command
{
    public class GasStove
    {
        public void StartGas()
        {
            Console.WriteLine("Gas started");
        }
        public void LightGas()
        {
            Console.WriteLine("Gas is lit");
        }
        public void StopStove()
        {
            Console.WriteLine("Gas turned off");
        }
    }
}
