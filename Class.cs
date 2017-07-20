using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD
{
    public class Class
    {
        protected string name { get; private set; }
        protected int defense { get; private set; }
        protected int attack { get; private set; }
        protected int speed { get; private set; }
        protected int health { get; private set; }

        public virtual string className
        { get { return name; } }

        public virtual int defenseModifier
        { get { return defense; } }

        public virtual int attackModifier
        { get { return attack; } }

        public virtual int speedModifier
        { get { return speed; } }

        public virtual int baseHealth
        { get { return health; } }

        public Class()
        { }

        public Class(string cname, int cdefense, int cattack, int cspeed, int chealth)
        {
            name = cname;
            defense = cdefense;
            attack = cattack;
            speed = cspeed;
            health = chealth;
        }
    }
    class Fighter : Class 
    {
        public Fighter()
            : base("Fighter", 1, 1, 0, 30)
        { }
    }
    class Paladin:Class
    {
        public Paladin()
            : base("Paladin", 2, -1, -1, 35)
        { }
    }
    class Ranger : Class
    {
        public Ranger()
            : base("Ranger", -1, 2, 2, 20)
        { }
    }
    class Barbarian : Class
    {
        public Barbarian()
            : base("Barbarian", -1, 1, 1, 25)
        { }
    }
    class Tank : Class
    {
        public Tank()
            : base("Tank", 4, -2, 0, 40)
        { }
    }
}
