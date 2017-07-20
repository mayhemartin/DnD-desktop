using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnD
{
    public partial class Creation : Form
    {
        //lists of all items/races/classes for display purposes
        List<Weapon> weapons = new List<Weapon>();
        List<Armor> armor = new List<Armor>();
        List<Class> classes = new List<Class>();
        List<Race> race = new List<Race>();
        Weapon selectedWeapon = null;
        Armor selectedArmor = null;
        Class selectedClass = null;
        Race selectedRace = null;
        public Character newPlayer = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            setBaseStats();
            //populate weapons
            weapons.Add(new Dagger());
            weapons.Add(new Mace());
            weapons.Add(new LongSword());
            weapons.Add(new DoubleAxe());
            weapons.Add(new DoubleSword());
            weapons.Add(new ExecutionAxe());
            //populate armor
            armor.Add(new Cloth());
            armor.Add(new Leather());
            armor.Add(new Chain());
            armor.Add(new Plate());
            //populate classes
            classes.Add(new Tank());
            classes.Add(new Fighter());
            classes.Add(new Paladin());
            classes.Add(new Ranger());
            classes.Add(new Barbarian());
            //populate races
            race.Add(new Human());
            race.Add(new Dwarf());
            race.Add(new Elf());
            race.Add(new Halfling());            
        }
        private void setBaseStats()
        {
            //set the possible base stats to let the player choose
            txtCol1.Text = Dice.getBaseStat().ToString();
            txtCol2.Text = Dice.getBaseStat().ToString();
            txtCol3.Text = Dice.getBaseStat().ToString();
        }
        public Creation()
        {
            InitializeComponent();

            rbStrength1.Click += new EventHandler(rbCol1_OnClick);
            rbConst1.Click += new EventHandler(rbCol1_OnClick);
            rbDext1.Click += new EventHandler(rbCol1_OnClick);

            rbStrength2.Click += new EventHandler(rbCol2_OnClick);
            rbConst2.Click += new EventHandler(rbCol2_OnClick);
            rbDext2.Click += new EventHandler(rbCol2_OnClick);

            rbStrength3.Click += new EventHandler(rbCol3_OnClick);
            rbConst3.Click += new EventHandler(rbCol3_OnClick);
            rbDext3.Click += new EventHandler(rbCol3_OnClick);
            
        }
        //Only one button in column one may be chosen
        private void rbCol1_OnClick(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            rbStrength1.Checked = false;
            rbConst1.Checked = false;
            rbDext1.Checked = false;

            rb.Checked = true;
            updateStats();
        }
        //only one button in column two may be chosen
        private void rbCol2_OnClick(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            rbStrength2.Checked = false;
            rbConst2.Checked = false;
            rbDext2.Checked = false;

            rb.Checked = true;
            updateStats();
        }
        //only one button in column three may be chosen
        private void rbCol3_OnClick(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            rbStrength3.Checked = false;
            rbConst3.Checked = false;
            rbDext3.Checked = false;

            rb.Checked = true;
            updateStats();
        }
        //upon selection of an option, the stats should "auto" update
        private void updateStats()
        {
            strength();
            constitution();
            dexterity();
            
            //calculate equipment weight
            if (selectedWeapon != null && selectedArmor != null)
                txtStatWeight.Text = Convert.ToString(selectedWeapon.weaponWeight + selectedArmor.armorWeight);

            else if (selectedWeapon != null)
                txtStatWeight.Text = Convert.ToString(selectedWeapon.weaponWeight);

            else if (selectedArmor != null)
                txtStatWeight.Text = Convert.ToString(selectedArmor.armorWeight);

            healthBonus();
            attackSpeed();

        }
        //updateStats breakdown - strength
        private void strength()
        {
            int strength=0;

            if (rbStrength1.Checked)
                strength = Convert.ToInt32(txtCol1.Text);

            else if (rbStrength2.Checked)
                strength = Convert.ToInt32(txtCol2.Text);

            else if (rbStrength3.Checked)
                strength = Convert.ToInt32(txtCol3.Text);

            if (selectedRace != null)
                strength += selectedRace.raceStrength;

            txtStatStrength.Text = Convert.ToString(strength);
            attackBonus();
        }
        //updateStats breakdown - constitution
        private void constitution()
        {
            int constitution = 0;

            if (rbConst1.Checked)
                constitution = Convert.ToInt32(txtCol1.Text);

            else if (rbConst2.Checked)
                constitution = Convert.ToInt32(txtCol2.Text);

            else if (rbConst3.Checked)
                constitution = Convert.ToInt32(txtCol3.Text);

            if (selectedRace != null)
                constitution += selectedRace.raceConst;

            txtStatConst.Text = Convert.ToString(constitution);
            defenseBonus();
        }
        //updateStats breakdown - dexterity
        private void dexterity()
        {
            int dexterity = 0;

            if (rbDext1.Checked)
                dexterity = Convert.ToInt32(txtCol1.Text);

            else if (rbDext2.Checked)
                dexterity = Convert.ToInt32(txtCol2.Text);

            else if (rbDext3.Checked)
                dexterity = Convert.ToInt32(txtCol3.Text);

            if (selectedRace != null)
                dexterity += selectedRace.raceDext;

            txtStatDext.Text = Convert.ToString(dexterity);
        }
        //updateStats breakdown - attackBonus
        private void attackBonus()
        {
            int strength = Convert.ToInt32(txtStatStrength.Text);
            int bonus;

            if (strength < 12)
                bonus = 0;
            else if (strength < 14)
                bonus = 1;
            else if (strength < 16)
                bonus = 2;
            else if (strength < 18)
                bonus = 3;
            else bonus = 4;

            if (selectedWeapon != null)
                bonus += selectedWeapon.weaponBonus;

            if (selectedClass != null)
                bonus += selectedClass.attackModifier;

            txtStatAttackBonus.Text = Convert.ToString(bonus);  
        }
        //updateStats breakdown - defenseBonus
        private void defenseBonus()
        {
            int constitution = Convert.ToInt32(txtStatConst.Text);
            int bonus=0;

            if (selectedArmor != null)
                bonus += selectedArmor.armorBonus;

            if (selectedClass != null)
                bonus += selectedClass.defenseModifier;

            txtStatDefenseBonus.Text = Convert.ToString(bonus);
        }
        //updateStats breakdown - health
        private void healthBonus()
        {
            int health=0;

            if (selectedClass != null)
            {
                health = selectedClass.baseHealth;
                int constitution = Convert.ToInt32(txtStatConst.Text);
                if (constitution < 12)
                    txtStatHP.Text = Convert.ToString(health);

                else if (constitution < 14)
                    txtStatHP.Text = Convert.ToString(health + 5);

                else if (constitution < 16)
                    txtStatHP.Text = Convert.ToString(health + 10);

                else if(constitution < 18)
                    txtStatHP.Text = Convert.ToString(health + 15);

                else txtStatHP.Text = Convert.ToString(health + 20);
            }
        }
        //updateStats breakdown - attack speed
        private void attackSpeed()
        {
            int dext = Convert.ToInt32(txtStatDext.Text);
            double speed=0;

            if(selectedWeapon != null)
                speed += selectedWeapon.weaponSpeed;

            if (selectedArmor != null)
                speed += selectedArmor.armorSpeed;

            if (dext < 14)
                speed -= .25;
            else if (dext < 16)
                speed -= .5;
            else if (dext < 18)
                speed -= .75;
            else speed -= 1;

            txtStatAttackSpeed.Text = Convert.ToString(speed);
        }
        private void btnReRoll_Click(object sender, EventArgs e)
        {
            setBaseStats();
            //reset all stats
            txtStatStrength.Text = "";
            txtStatConst.Text = "";
            txtStatDext.Text = "";

            //reset stat selections
            rbStrength1.Checked = false;
            rbStrength2.Checked = false;
            rbStrength3.Checked = false;

            rbConst1.Checked = false;
            rbConst2.Checked = false;
            rbConst3.Checked = false;

            rbDext1.Checked = false;
            rbDext2.Checked = false;
            rbDext3.Checked = false;

            updateStats();
        }

        private void cbWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWeapon = weapons[cbWeapon.SelectedIndex];
            lblWeaponWeight.Text = selectedWeapon.weaponWeight.ToString()+" lbs.";
            lblWeaponBonus.Text = selectedWeapon.weaponBonus.ToString();
            lblWeaponRoll.Text = selectedWeapon.weaponRoll.ToString() + "d" + selectedWeapon.weaponDamage.ToString();
            picWeapon.Image = selectedWeapon.weaponImage;
            weapDesc.Text = selectedWeapon.weaponDesc;
            lblAttack.Text = "attack";
            lblWeaponSpeed.Text = "Speed: "+Convert.ToString(selectedWeapon.weaponSpeed);
            updateStats();
        }

        private void cbArmor_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedArmor = armor[cbArmor.SelectedIndex];
            lblArmorWeight.Text = selectedArmor.armorWeight.ToString() + " lbs.";
            lblDefBonus.Text = selectedArmor.armorBonus.ToString();
            picArmor.Image = selectedArmor.armorImage;
            armorDesc.Text = selectedArmor.armorDesc;
            lblDefense.Text = " defense";
            lblArmorSpeed.Text = "Speed: "+Convert.ToString(selectedArmor.armorSpeed);
            updateStats();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedClass = classes[cbClass.SelectedIndex];
            updateStats();
        }

        private void cbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRace = race[cbRace.SelectedIndex];
            updateStats();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            newPlayer = new Character(txtName.Text,
                                Convert.ToInt32(txtStatStrength.Text),
                                Convert.ToInt32(txtStatConst.Text),
                                Convert.ToInt32(txtStatDext.Text),
                                selectedWeapon,selectedArmor,selectedRace,selectedClass);

            Arena battleArena = new Arena();
            battleArena.player = newPlayer;
            battleArena.Show();
            battleArena.FormClosed += new FormClosedEventHandler(battleArena_FormClosed);
            this.Hide();
        }
        void battleArena_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rbStrength1.Checked = false;
            rbStrength2.Checked = false;
            rbStrength3.Checked = false;
            rbConst1.Checked = false;
            rbConst2.Checked = false;
            rbConst3.Checked = false;
            rbDext1.Checked = false;
            rbDext2.Checked = false;
            rbDext3.Checked = false;
            txtName.Text = "";
            txtStatStrength.Text = "";
            txtStatConst.Text = "";
            txtStatDext.Text = "";

            updateStats();
        }
    }
}
