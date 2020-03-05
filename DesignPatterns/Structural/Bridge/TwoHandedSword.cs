using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Bridge
{
    public class TwoHandedSword : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Attacking by a two-handed sword");
        }

        public void Defend()
        {
            Console.WriteLine("Defending by a two-handed sword");
        }
    }
}
