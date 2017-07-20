DnD a.k.a Combat Mechanic v. 4.2.14
***********************************************************
Glaring problems with the implemenation:
- Health bars update, but the health labels do not
- The coin flip choose, doesn't appear to be random as it should be
- small problems with labels being aligned (ran out of time)

***********************************************************
Weapons & Armor
***********************************************************
Weapon and Armor classes, hold several children that inherit
these two main classes, and simply create different iterations of
their parent class. This allows for the constructor to be called
in the main program or character selection, without having to worry
about the stats and details of the weapons or armor.

***********************************************************
Races
***********************************************************
Tried to implement some races in here, didn't get around to
making a display section to explain their history, and/or perks.
- Human : no modifications
- Dwarf : +2 Const
- Elf : -2 Const, +2 Dext
- Halfling : -2 Strength, +2 Dext

Again, there is a Race class that has sub-classes with no additional
functionality, but allows for specifying the class

***********************************************************
Classes
***********************************************************
Tried to implement some classes in here.  Speed is an available
field to alter in the various classes, but is not implemented to the
actual attack speed. It would have given a base attack speed though.
Had there been a section to explain about the modifiers for the classes, 
and a descriptive section, there would have been a string description
field available as well.
- Fighter: +1 Defense, +1 Attack, 30 base health
- Paladin : +2 Defense, -1 Attack, -1 Speed, 35 base health
- Ranger : =1 Defense, +2 Attack, +2 Speed, 20 base health
- Barbarian : -1 Defense, +1 Attack, +1 Speed, 25 base health
- Tank : +4 Defense, -2 Attack, 40 base health