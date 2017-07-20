using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD
{
    public class Race
    {
        protected string name { get; private set; }
        protected int strength { get; private set; }
        protected int constitution { get; private set; }
        protected int dexterity { get; private set; }
        protected string description { get; private set; }

        public virtual string raceName
        { get { return name; } }
        public virtual int raceStrength
        { get { return strength; } }
        public virtual int raceConst
        { get { return constitution; } }
        public virtual int raceDext
        { get { return dexterity; } }
        public virtual string raceDesc
        { get { return description; } }

        public Race()
        { }
        public Race(string rName, int rStrength, int rConst, int rDext, string rDesc)
        {
            name = rName;
            strength = rStrength;
            constitution = rConst;
            dexterity = rDext;
            description = rDesc;
        }
    }
    class Human : Race
    {
        public Human()
            : base("Human", 0, 0, 0, "")
        { }
    }
    class Dwarf : Race
    {
        public Dwarf()
            : base("Dwarf", 0, 2, 0, "")
        { }
    }
    class Elf : Race
    {
        public Elf()
            : base("Elf", 0, -2, 2, "")
        { }
    }
    class Halfling : Race
    {
        public Halfling()
            : base("Halfling", -2, 0, 2, "")
        { }
    }
}
