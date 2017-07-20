using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD
{
    public class Character
    {
        
        protected string userName {get; private set;}
        protected int userStrength {get; private set;}
        protected int userConstitution { get; private set; }
        protected int userDexterity { get; private set; }
        public int currentHealth { get; set; }
        protected double turnSpeed { get; private set; }

        protected Weapon userWeapon { get; private set; }
        protected Armor userArmor { get; private set; }
        protected Race userRace { get; private set; }
        protected Class userClass { get; private set; }

        public virtual string name
        { get { return userName; } }
        public virtual int strength
        { get { return userStrength; } }
        public virtual int constitution
        { get { return userConstitution; } }
        public virtual int dexterity
        { get { return userDexterity; } }
        public virtual Weapon weapon
        { get { return userWeapon; } }
        public virtual Armor armor
        { get { return userArmor; } }
        public virtual Race race
        { get { return userRace; } }
        public virtual Class getClass
        { get { return userClass; } }
        public virtual double speed
        { get { return turnSpeed; } }

        public double attackSpeed()
        {
            double speed = 0;
            //int weight = 0;

           speed += userWeapon.weaponSpeed;

            speed += userArmor.armorSpeed;

            if (userDexterity < 14)
                speed -= .25;
            else if (userDexterity < 16)
                speed -= .5;
            else if (userDexterity < 18)
                speed -= .75;
            else speed -= 1;

            return speed;
        }
        public int health()
        {
            int health = userClass.baseHealth;
            if (userConstitution < 12)
                health += 0;
            else if (userConstitution < 14)
                health += 5;
            else if (userConstitution < 16)
                health += 10;
            else if (userConstitution < 18)
                health += 15;
            else health += 20;

            return health;
        }
        public int attackBonus()
        {
            int bonus = 0;

            if (userStrength < 12)
                bonus += 0;

            else if (userStrength < 14)
                bonus += 1;

            else if (userStrength < 16)
                bonus += 2;

            else if (userStrength < 18)
                bonus += 3;

            else bonus += 4;

            bonus += userWeapon.weaponBonus;

            bonus += userClass.attackModifier;

            return bonus;
        }
        public int defenseBonus()
        {
            int bonus = 0;

            bonus += userArmor.armorBonus;
            bonus += userClass.defenseModifier;

            return bonus;
        }
        public Character()
        {
            userName = "Destroyer of Users";
            userStrength = Convert.ToInt32(Dice.getBaseStat());
            userConstitution = Convert.ToInt32(Dice.getBaseStat());
            userDexterity = Convert.ToInt32(Dice.getBaseStat());

            List<Weapon> tempWeapon = new List<Weapon>();
            tempWeapon.Add(new Dagger());
            tempWeapon.Add(new Mace());
            tempWeapon.Add(new LongSword());
            tempWeapon.Add(new DoubleAxe());
            tempWeapon.Add(new DoubleSword());
            tempWeapon.Add(new ExecutionAxe());
            userWeapon = tempWeapon[Dice.random(1, tempWeapon.Count-1)];

            List<Armor> tempArmor = new List<Armor>();
            tempArmor.Add(new Cloth());
            tempArmor.Add(new Leather());
            tempArmor.Add(new Chain());
            tempArmor.Add(new Plate());
            userArmor = tempArmor[Dice.random(1, tempArmor.Count-1)];

            List<Race> tempRace = new List<Race>();
            tempRace.Add(new Human());
            tempRace.Add(new Dwarf());
            tempRace.Add(new Elf());
            tempRace.Add(new Halfling());
            userRace = tempRace[Dice.random(1, tempRace.Count - 1)];

            List<Class> tempClass = new List<Class>();
            tempClass.Add(new Tank());
            tempClass.Add(new Fighter());
            tempClass.Add(new Paladin());
            tempClass.Add(new Ranger());
            tempClass.Add(new Barbarian());
            userClass = tempClass[Dice.random(1, tempClass.Count - 1)];

            currentHealth = health();

        }
        public Character(string charName, int charStrength, int charConst, int charDext, Weapon charWeapon, Armor charArmor, Race charRace, Class charClass)
        {
            userName = charName;
            userStrength = charStrength;
            userConstitution = charConst;
            userDexterity = charDext;
            userWeapon = charWeapon;
            userArmor = charArmor;
            userRace = charRace;
            userClass = charClass;
            currentHealth = health();

        }
        
    }
}
