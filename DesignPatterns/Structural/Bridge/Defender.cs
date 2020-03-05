using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Bridge
{
    public class Defender : Warrior
    {
        public Defender(IWeapon Weapon) : base(Weapon) { }

        public Defender() : this(new SwordAndShield()) { }

        public override void MakeABattleCry()
        {
            Console.WriteLine("Defender battle cry");
        }
    }
}
