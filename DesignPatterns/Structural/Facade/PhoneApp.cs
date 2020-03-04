using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Facade
{
    public class PhoneApp
    {
        public void StartApp()
        {
            Console.WriteLine("Starting application.");
        }

        public void StopApp()
        {
            Console.WriteLine("Stopping application.");
        }
    }
}
