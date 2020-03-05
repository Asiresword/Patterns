using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Bridge
{
    public class SwordAndShield : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Attacking by a sword");
        }

        public void Defend()
        {
            Console.WriteLine("Defending by a shield");
        }
    }
}
