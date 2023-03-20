using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RandomNumbersIntro
{
    public partial class FrmRandomNumberIntro : Form
    {
        public FrmRandomNumberIntro()
        {
            InitializeComponent();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            
            Random r = new Random();
            
            int rNumber;

            for (int i = 1; i <= 100; i++)
            {
                rNumber = r.Next(10);   //0-9
                LstDisplay.Items.Add(Convert.ToString(rNumber));
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOneToSix_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            
            Random r = new Random();

            int rNumber;

            for (int i = 1; i <= 100; i++)
            {
               rNumber = r.Next(1, 7);
               //rNumber = r.Next(6) +1 ;   1-6 (Hi-Lo+1) + Lo
               LstDisplay.Items.Add(Convert.ToString(rNumber));
            }
        }

        private void BtnSevenToTwenty_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            
            Random r = new Random();

            int rNumber;

            for (int i = 1; i <= 100; i++)
            {
                rNumber = r.Next(7, 21);
                //rNumber = r.Next(14) + 7;   (Hi-Lo) + Lo                
                LstDisplay.Items.Add(Convert.ToString(rNumber));
            }
        }

        private void BtnHeadsTails_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            
            int heads = 0;
            int tails = 0;

            int toss;

            Random r = new Random();

            for (int i = 1; i <= 100; i++)
            {
                toss = r.Next(1, 3);
                if (toss == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }

            LstDisplay.Items.Add("Heads " + Convert.ToString(heads));
            LstDisplay.Items.Add("Tails " + Convert.ToString(tails));

        }

        private void BtnProblem3_Click(object sender, EventArgs e)
        {
            decimal firstGameCost = 8.00m;

            decimal secondGameCost = 15.00m;

            decimal sum1 = 0;
            decimal sum2 = 0;

            for(int i = 0; i < 1000; i++)
            {
                Random r = new Random();
                int firstAddition = r.Next(1, 7);
                int secondAddition = r.Next(1, 7);

                sum1 += firstAddition + secondAddition - firstGameCost;
            }

            for(int j = 0; j < 1000; j++)
            {
                Random r2 = new Random();
                int firstMultiplication = r2.Next(1, 7);
                int secondMultiplication = r2.Next(1, 7);
                sum2 += firstMultiplication * secondMultiplication - secondGameCost;
            }

            MessageBox.Show("Avg per game addition is: " + sum1 /1000);
            MessageBox.Show("Avg per game mulitplication is: " + sum2 / 1000);
            if (sum1 > sum2)
            {
                MessageBox.Show("Pick addition");
            }
            else
            {
                MessageBox.Show("Pick multiplication");
            }
        }
    }
}