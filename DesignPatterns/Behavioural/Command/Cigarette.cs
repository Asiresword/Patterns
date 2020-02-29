using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Command
{
    public class Cigarette
    {
        public void StartBurning()
        {
            Console.WriteLine("Cigarette burning");
        }
        public void StartSmoking()
        {
            Console.WriteLine("Cigarette smoking");
        }
        public void PutOut()
        {
            Console.WriteLine("Cigarette has been put out");
        }
    }
}
