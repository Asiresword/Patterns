using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Facade
{
    public class PhoneOS
    {
        public void StartOS()
        {
            Console.WriteLine("Starting Phone OS...");
        }

        public void ShutdownOS()
        {
            Console.WriteLine("Shutting down...");
        }
    }
}
