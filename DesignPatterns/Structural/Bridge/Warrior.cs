using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Bridge
{
    public abstract class Warrior
    {
        protected IWeapon Weapon { get; set; }
        public Warrior(IWeapon Weapon)
        {
            this.Weapon = Weapon;
        }

        public virtual void SetWeapon(IWeapon Weapon)
        {
            this.Weapon = Weapon;
        }

        public virtual void Attack()
        {
            this.Weapon.Attack();
        }

        public virtual void Defend()
        {
            this.Weapon.Defend();
        }

        public abstract void MakeABattleCry();
    }
}
