using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmStats : Form
    {
        public FrmStats()
        {
            InitializeComponent();
        }

        //*********************VARIABLES*********************
        //TeamMember[7] Team = team members sent from main form
        //int members = number of team members sent from main form
        //Graphics g = graphics class
        //Image[7] Teammembers = images for each member
        //Image attack = image for attack
        //Image target = image for target
        //int[7] x = x position of each member
        //int[7] y = y position of each member
        //int[7] attackx = x position of each attack
        //int[7] targetx = x position of each target
        //int mode = stat being checked
        //***************************************************

        TeamMember[] Team = new TeamMember[7];
        int members = 0;

        Image[] Teammembers = new Image[7];
        Image attack;
        Image target;

        int[] x = new int[7];
        int[] y = new int[7];
        int[] attackx = new int[7];
        int[] targetx = new int[7];

        int mode = 1;

        public void GetInfo(TeamMember[] team, int num)
        {
            //gets number of members from main form
            members = num;

            //gets info from main form and loads in sprites
            for (int i = 1; i <= members; i++)
            {
                Team[i] = new TeamMember();
                Team[i] = team[i];
                Teammembers[i] = Image.FromFile(Application.StartupPath + @"\sprites\icons\dpicon" + Team[i].number + ".png");
                Teammembers[i].RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            //load attack and target sprites
            attack = Image.FromFile(Application.StartupPath + @"\sprites\attack.png");
            target = Image.FromFile(Application.StartupPath + @"\sprites\icons\dpicon129.png");

            //move things off-screen
            for (int i = 1; i <= members; i++)
            {
                x[i] = -200;
                targetx[i] = -200;
                attackx[i] = -200;
            }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Draw(g);
        }

        private void Draw(Graphics g)
        {
            //clears panel
            g.Clear(PnlGame.BackColor);


            for (int i = 1; i <= members; i++)
            {
                //draws members
                g.DrawImage(Teammembers[i], new Point(x[i], y[i]));
                //draws targets
                g.DrawImage(target, new Point(targetx[i], y[i]));
                //draws image
                g.DrawImage(attack, new Point(attackx[i], y[i]));
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= members; i++)
            {
                //moves attack off-screen
                attackx[i] = -200;

                //if atk or def, place pokemon in centre of screen
                if (mode != 3)
                    x[i] = PnlGame.ClientRectangle.Width / 2;
                //if spd, place pokemon at left of screen
                else
                    x[i] = 0;

                //spread out y positions
                y[i] = i * 30 + i * 10;

                //if atk, draw targets, else move off-screen
                if (mode == 1)
                    targetx[i] = x[i] + PnlGame.ClientRectangle.Width / 4;
                else
                    targetx[i] = -200;

                //refresh
                PnlGame.Invalidate();
            }

            //allow start to be pressed
            BtnStart.Enabled = true;
        }

        private void TimRun_Tick(object sender, EventArgs e)
        {
            //random number generator
            Random r = new Random();

            for (int i = 1; i <= members; i++)
            {
                //random number from 1 to spd
                int move = r.Next(1, Team[i].spd);

                //move by random number/10
                if (move / 10 == 0)
                    move = 10;

                //change x position and refresh
                x[i] += move / 10;
                PnlGame.Invalidate();
            }

            for (int f = 1; f <= members; f++)
            {
                //if a member reaches the end of the panel
                if (x[f] >= PnlGame.ClientRectangle.Width - Teammembers[f].Size.Width)
                {
                    //turn timer off, show message and enable button
                    TimSpeed.Enabled = false;
                    MessageBox.Show(Team[f].nickname + " is fastest!");
                    BtnSet.Enabled = true;
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //if atk
            if (mode == 1)
            {
                //start atk run
                TimAttack.Enabled = true;
                ResetAttackPosition();
            }
            //if def
            else if (mode == 2)
            {
                //start def run
                TimDefence.Enabled = true;
                ResetAttackPosition();
            }
            //if spd
            else
            {
                //start spd run
                TimSpeed.Enabled = true;
            }

            //disable both buttons
            BtnSet.Enabled = false;
            BtnStart.Enabled = false;
        }

        private void ResetAttackPosition()
        {
            for (int i = 1; i <= members; i++)
            {
                //if atk, set attack on pokemon
                if (mode == 1)
                    attackx[i] = x[i] + Teammembers[i].Size.Width;
                //if def, set attack at the far right of the screen
                else
                    attackx[i] = PnlGame.ClientRectangle.Width + attack.Size.Width;
            }
        }

        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            //turn all timers off
            TimAttack.Enabled = false;
            TimDefence.Enabled = false;
            TimSpeed.Enabled = false;
        }

        private void RdoAtk_CheckedChanged(object sender, EventArgs e)
        {
            //set to atk and disable button
            mode = 1;
            BtnStart.Enabled = false;
        }

        private void RdoDef_CheckedChanged(object sender, EventArgs e)
        {
            //set to def and disable button
            mode = 2;
            BtnStart.Enabled = false;
        }

        private void RdoSpd_CheckedChanged(object sender, EventArgs e)
        {
            //set to spd and disable button
            mode = 3;
            BtnStart.Enabled = false;
        }

        private void TimAttack_Tick(object sender, EventArgs e)
        {
            //random number generator
            Random r = new Random();

            for (int i = 1; i <= members; i++)
            {
                //move attack to the right
                attackx[i] += 5;

                //if target is hit
                if (attackx[i] > targetx[i])
                {
                    //random number between 50 and atk x 5
                    int move = r.Next(50, Team[i].atk * 5);

                    //move target to the right
                    targetx[i] += move / 10;
                    attackx[i] = x[i] + Teammembers[i].Size.Width;
                }

                //refresh
                PnlGame.Invalidate();
            }

            for (int i = 1; i <= members; i++)
            {
                //if target is off-screen
                if (targetx[i] > PnlGame.ClientRectangle.Width)
                {
                    //turn timer off
                    TimAttack.Enabled = false;
                    MessageBox.Show(Team[i].nickname + " has the most power!");
                    BtnSet.Enabled = true;
                }
            }
        }

        private void TimDefence_Tick(object sender, EventArgs e)
        {
            //random number generator
            Random r = new Random();

            //counter for counting pokemon that lost
            int counter = 0;

            for (int i = 1; i <= members; i++)
            {
                //move attack to the left
                attackx[i] -= 5;

                //if attack hits pokemon
                if (attackx[i] < x[i] + 10)
                {
                    //random number between 80 and 100
                    int move = r.Next(80, 100);

                    //move pokemon to the left by random number - def/2
                    x[i] -= move - Team[i].def / 2;
                    attackx[i] = PnlGame.ClientRectangle.Width;
                }

                //if the pokemon is off-screen
                if (x[i] > 0 - Teammembers[i].Size.Width)
                {
                    //refresh
                    PnlGame.Invalidate();
                }
                //otherwise, count it
                else
                    counter++;
            }

            //if one member is left
            if (counter >= members - 1)
            {
                //turn off timer
                TimDefence.Enabled = false;

                for (int i = 1; i <= members; i++)
                {
                    //find winner and display message
                    if (x[i] > 0 - Teammembers[i].Size.Width)
                        MessageBox.Show(Team[i].nickname + " endured the longest!");
                }

                //enable button
                BtnSet.Enabled = true;
            }
        }
    }
}
