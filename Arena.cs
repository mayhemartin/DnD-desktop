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
    public partial class Arena : Form
    {
        public Character player = null;
        public Character computer = null;

        public Arena()
        {
            InitializeComponent();
        }
        private void Arena_Load(object sender, EventArgs e)
        {    
            //load human player info
            lblName.Text = player.name;
            lblStrength.Text = "Strength: "+Convert.ToString(player.strength);
            lblConst.Text = "Const: "+Convert.ToString(player.constitution);
            lblSpeed.Text = "Attack Speed: "+Convert.ToString(player.attackSpeed());
            lblAttackBonus.Text = "+ "+Convert.ToString(player.attackBonus())+" attack";
            lblDefenseBonus.Text = "+ "+Convert.ToString(player.defenseBonus())+" defense";
            int health = player.health();
            pbPlayer.Maximum = health;
            pbPlayer.Value = health;
            lblTotalHealth.Text = " / "+Convert.ToString(health);
            lblCurrentHealth.Text = Convert.ToString(health);

            lblRC.Text = player.race.raceName + " / " + player.getClass.className;

            playerWeap.Image = player.weapon.weaponImage;
            playerArmor.Image = player.armor.armorImage;

            //load computer player info
            computer = new Character();
            lblCompName.Text = computer.name;
            lblCompStrength.Text = "Strength: " + Convert.ToString(computer.strength);
            lblCompConst.Text = "Const: " + Convert.ToString(computer.constitution);
            lblCompSpeed.Text = "Attack Speed: "+Convert.ToString(computer.attackSpeed());
            lblCompAttackBonus.Text = "+ "+Convert.ToString(computer.attackBonus())+" attack";
            lblCompDefenseBonus.Text = "+ "+Convert.ToString(computer.defenseBonus())+" defense";
            pbComp.Maximum = computer.currentHealth;
            pbComp.Value = computer.currentHealth;
            lblCompTotalHealth.Text = "/ "+Convert.ToString(computer.currentHealth);
            lblCompCurrentHealth.Text = Convert.ToString(computer.currentHealth);

            lblCompRC.Text = computer.race.raceName + " / " + computer.getClass.className;
            compWeap.Image = computer.weapon.weaponImage;
            compArmor.Image = computer.armor.armorImage;

            //for fun
            pbFlip.Image = DnD.Properties.Resources.coinflip;
        }
        //History of the battle
        private void record(string message)
        {
            history.AppendText(message + "\n");
        }
        //main function
        private void toTheDeath(int firstTurn)
        {
            int turn=firstTurn; //overall turn
            //player turn
            if (turn == 0)
                record("Human Player set to begin..");

            else record("Computer Player set to begin..");

            /*the total turn is incremented by .25.
              The decider for attacking is the modulus division of the current
              total turn % their respective attack speed. A zero result means
              they get to attack. Allowing for very variable attack speeds.*/
            double turnSpeed = .25;

            double player1 = player.attackSpeed();
            double player2 = computer.attackSpeed();

            //continue until someone is dead
            while (player.currentHealth > 0 && computer.currentHealth > 0)
            {
                if (turn == 0 && ((turnSpeed%player1) == 0))
                {
                    //Decide if you can attack
                    if ((Dice.random(1, 20) + player.attackBonus()) > (computer.defenseBonus()) + computer.constitution)
                    {
                        int damage = 0;
                        //tally up the damage
                        for (int i = 0; i < player.weapon.weaponRoll; i++)
                            damage += Dice.random(1, player.weapon.weaponDamage);

                        //get your name in the history book
                        record("Human hits Computer: - " + damage);
                        //update health
                        computer.currentHealth = computer.currentHealth - damage;

                        //adjust the health trackers of the player you hit
                        if (computer.currentHealth < 0)
                        {
                            pbComp.Value = 0;
                            lblCompCurrentHealth.Text = Convert.ToString(0);
                        }

                        else
                        {
                            pbComp.Value = computer.currentHealth;
                            lblCompCurrentHealth.Text = Convert.ToString(computer.currentHealth);
                        }
                    }
                    else
                    {
                        //Your opponent has a silly amount of defense
                        record("Human misses Computer.");
                    }
                    //switch turns
                    turn = 1;
                }
                if( turn == 1 && ((turnSpeed%player2) == 0))
                {
                    if ((Dice.random(1, 20) + computer.attackBonus()) > (player.defenseBonus()) + player.constitution)
                    {
                        int damage = 0;
                        for (int i = 0; i < computer.weapon.weaponRoll; i++)
                            damage += Dice.random(1, computer.weapon.weaponDamage);

                        record("Computer hits Human: - " + damage);
                        player.currentHealth = player.currentHealth - damage;

                        
                    }
                    else
                    {
                        record("Computer misses Human.");
                    }
                    if (player.currentHealth < 0)
                    {
                        pbPlayer.Value = 0;
                        lblCurrentHealth.Text = Convert.ToString(0);
                    }

                    else
                    {
                        pbPlayer.Value = player.currentHealth;
                        lblCurrentHealth.Text = Convert.ToString(player.currentHealth);
                    }
                    turn = 0;
                }
                turnSpeed += .25; //increment total turn
                System.Threading.Thread.Sleep(250); //pause for 1/4 a second
            }
            //Declare if its a win or loss
            if (player.currentHealth > 0)
            {
                record("Human Wins !!");
                lblResult.Text = "Victory !!";
                lblResult.ForeColor = System.Drawing.Color.Blue;
                lblResult.Visible = true;
            }

            else
            {
                record("Computer Wins !!");
                lblResult.Text = "Defeat !!";
                lblResult.ForeColor = System.Drawing.Color.Red;
                lblResult.Visible = true;
            }

            btnRePlay.Visible = true;
            btnExit.Visible = true;


        }
        private void setHealth(Character player, Label health)
        {
            if (player.currentHealth < 0)
                health.Text = Convert.ToString(0);
            else health.Text = Convert.ToString(player.currentHealth);
        }
        private void head_Click(object sender, EventArgs e)
        {
            int turn;

            pbFlip.Visible = false;
            head.Visible = false;
            tail.Visible = false;

            if (Dice.random(0, 1) == 0)
                turn = 0;

            else turn = 1;

            toTheDeath(turn);
        }
        private void tail_Click(object sender, EventArgs e)
        {
            int turn;
            pbFlip.Visible = false;
            head.Visible = false;
            tail.Visible = false;

            if (Dice.random(0, 1) == 1)
                turn = 0;

            else turn = 1;

            toTheDeath(turn);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRePlay_Click(object sender, EventArgs e)
        {
            Creation recreate = new Creation();
            recreate.Show();
            this.Hide();
        }
    }
}
