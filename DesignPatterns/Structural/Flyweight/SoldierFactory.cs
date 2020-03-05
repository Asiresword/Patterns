using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Flyweight
{
    public class SoldierFactory
    {
        private Hashtable Soldiers { get; set; }
        public SoldierFactory()
        {
            this.Soldiers = new Hashtable();
        }

        public Soldier GetSoldier(char key)
        {
            Soldier soldier = Soldiers[key] as Soldier;
            if (soldier == null)
            {
                switch (key)
                {
                    case 'S': 
                        soldier = new Sergeant(); 
                        break;
                    case 'L': 
                        soldier = new Lieutenant(); 
                        break;
                    case 'G': 
                        soldier = new General(); 
                        break;
                }
                Soldiers.Add(key, soldier);
            }
            return soldier;
        }
    }
}
