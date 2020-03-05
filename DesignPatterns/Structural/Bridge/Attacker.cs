using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Bridge
{
    public class Attacker : Warrior
    {
        public Attacker(IWeapon Weapon) : base(Weapon) { }

        public Attacker() : this(new TwoHandedSword()) { }

        public override void MakeABattleCry()
        {
            Console.WriteLine("Attacker battle cry");
        }
    }
}
