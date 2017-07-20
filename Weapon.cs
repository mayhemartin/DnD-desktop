using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD
{
    public class Weapon
    {
        protected string name{get; private set;}
        protected int weight{get; private set;}
        protected System.Drawing.Image image { get; private set; }
        protected int bonus { get; private set; }
        protected int roll { get; private set; }
        protected int damage { get; private set; }
        protected double speed { get; private set; }
        protected string description { get; private set; }

        public virtual string weaponName
        { get { return name; } }
        public virtual int weaponWeight
        { get { return weight; } }
        public virtual System.Drawing.Image weaponImage
        { get { return image; } }
        public virtual int weaponBonus
        { get { return bonus; } }
        public virtual int weaponRoll
        { get { return roll; } }
        public virtual int weaponDamage
        { get { return damage; } }
        public virtual double weaponSpeed
        { get { return speed; } }
        public virtual string weaponDesc
        { get { return description; } }

        public Weapon()
        {}

        public Weapon(string wname, int wweight, System.Drawing.Image wimage, int wroll, int wdamage, int wbonus, double wspeed, string wdesc)
        {
            name = wname;
            weight = wweight;
            image = wimage;
            bonus = wbonus;
            roll = wroll;
            damage = wdamage;
            description = wdesc;
            speed = wspeed;
        }
    }
    class Dagger : Weapon
    {
        public Dagger()
            : base("Dagger", 1, DnD.Properties.Resources.dagger, 1, 4, 3, .5,"A simple one-handed  " +
            "melee weapon in the light blade weapon group. This weapon gives a plus (+)3 bonus to attack.")
        { }
    }
    class Mace : Weapon
    {
        public Mace()
            : base("Mace", 6, DnD.Properties.Resources.mace, 1, 8, 2, .75,"A simple one-handed melee weapon " +
            "in the mace weapon group. This weapon gives a plus (+)2 bonus to attack.")
        { }
    }
    class LongSword : Weapon
    {
        public LongSword()
            : base("Long Sword", 4, DnD.Properties.Resources.longSword, 1, 8, 3, .75,"A military one-handed " +
            "melee weapon in the heavy blade weapon group. This weapon gives a plus (+)3 bonus to attack.")
        { }
    }
    class ExecutionAxe : Weapon
    {
        public ExecutionAxe()
            : base("Execution Axe", 14, DnD.Properties.Resources.executionAxe, 1, 12, 2, 1.5,"A superior two-handed " +
            "melee weapon in the axe weapon group. This weapon gives a plus (+)2 bonus to attack.")
        { }
    }
    class DoubleSword : Weapon
    {
        public DoubleSword()
            : base("Double Sword", 9, DnD.Properties.Resources.doubleSword, 2, 6, 3, 1,"A superior double " +
            "melee weapon in the light blade weapon group. This weapon gives a plus (+)3 bonus to attack.")
        { }
    }
    class DoubleAxe : Weapon
    {
        public DoubleAxe()
            : base("Double Axe", 15, DnD.Properties.Resources.doubleAxe, 2, 10, 2, 1.5,"A superior double " +
        "melee weapon in the axe weapon group. This weapon gives a plus (+)2 bonus to attack.")
        { }
    }
}
