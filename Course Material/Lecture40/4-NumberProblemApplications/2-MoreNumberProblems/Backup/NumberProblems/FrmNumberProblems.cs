using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NumberProblems
{
    public partial class FrmNumberProblems : Form
    {
        public FrmNumberProblems()
        {
            InitializeComponent();
        }        

        private void BtnProblem5_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            LstDisplay.Items.Add("Numbers between 1000 and 2000 divisible by the sum of their squares");
            LstDisplay.Items.Add("");

            for (int number = 1000; number <= 2000; number++)
            {
                double sum=0;

                string num = Convert.ToString(number);

                for (int digit = 0; digit < num.Length; digit++)
                {
                    sum+= Math.Pow(int.Parse(num.Substring(digit, 1)),2);
                }


                if (sum != 0)
                {
                    if (number % sum == 0)
                    {
                        LstDisplay.Items.Add(number.ToString() + "\t" + "is divisible by the sum of the squares of its digits " + "\t" + sum.ToString());
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProblem6_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            LstDisplay.Items.Add("3 digit reversed and multiplied perfect squares ");
            LstDisplay.Items.Add("");

            for (int number = 100; number <= 300; number++)
            {
                string num = Convert.ToString(number);
                string revnum="";

                for (int digit = num.Length-1; digit >=0 ; digit--)
                {
                    revnum += num.Substring(digit, 1);
                }

                int product=int.Parse(num)*int.Parse(revnum);

                double p1=Math.Sqrt(product);
                int p2 = (int) Math.Sqrt(product);

                if (p1==p2)
                {
                    LstDisplay.Items.Add(number.ToString()+ "\t" + "reversed number-> "+ revnum.ToString() + "\t" + "product-> "+ product.ToString());
                }

            }
        }
    }
}