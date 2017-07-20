using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD
{
    public class Armor
    {
        protected string name { get; private set; }
        protected int weight { get; private set; }
        protected System.Drawing.Image image { get; private set; }
        protected int bonus { get; private set; }
        protected double speed { get; private set; }
        protected string description { get; private set; }

        public virtual string armorName
        { get { return name; } }
        public virtual int armorWeight
        { get { return weight; } }
        public virtual System.Drawing.Image armorImage
        { get { return image; } }
        public virtual int armorBonus
        { get { return bonus; } }
        public virtual double armorSpeed
        { get { return speed; } }
        public virtual string armorDesc
        { get { return description; } }

        public Armor()
        { }
        public Armor(string aname, int aweight, System.Drawing.Image aimage, int abonus, double aspeed, string adesc)
        {
            name = aname;
            weight = aweight;
            image = aimage;
            bonus = abonus;
            speed = aspeed;
            description = adesc;
        }
    }
    class Cloth : Armor
    {
        public Cloth()
            : base("Cloth Armor", 4, DnD.Properties.Resources.cloth, 0, .5,"The most basic "+
            "form of armor. This armor doesn't slow you down or hinder your movement at all. "+
            "Provides +(0) defense and .5 speed modification.")
        { }
    }
    class Leather : Armor
    {
        public Leather()
            : base("Leather Armor", 15, DnD.Properties.Resources.leather, 2, 1, "Sturdier than cloth armor. " +
            "This is the second lightest armor available, and protects vital areas with multiple layers of " +
            "boilded-leather plates. Provides +(2) defense and 1 speed modification.")
        { }
    }
    class Chain : Armor
    {
        public Chain()
            : base("Chain Mail", 40, DnD.Properties.Resources.chain, 6, 1.5, "Decent defense using " +
            "inter-woven metal chains. A little on the heavier side, but lighter than plate mail. " +
            "Provides +(6) defense and 1.5 speed modification.")
        { }
    }
    class Plate : Armor
    {
        public Plate()
            : base("Plate Armor", 50, DnD.Properties.Resources.plate, 8, 2, "Heaviest armor " +
            "available, giving very good defense, but penalizing attack speed. " +
            "Provides +(8) defense and 2 speed modification.")
        { }
    }
}
