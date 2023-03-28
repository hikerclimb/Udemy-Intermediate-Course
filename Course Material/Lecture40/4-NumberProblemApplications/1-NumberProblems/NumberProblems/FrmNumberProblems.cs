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

        private void BtnIntro_Click(object sender, EventArgs e)
        {
            string number;
            int sum = 0;
            int product = 1;

            number = Microsoft.VisualBasic.Interaction.InputBox("Enter a number ", "Application of Strings", "", 200, 200);

            for (int i = 0; i <number.Length ; i++)
            {
                sum += int.Parse(number.Substring(i, 1));
                product *= int.Parse(number.Substring(i, 1));
            }

            MessageBox.Show("The sum of the digits in " + number.ToString() + " is " + sum.ToString() + "\n" + "The product of the digits is " + product.ToString());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProblem4_Click(object sender, EventArgs e)
        {
            LstDisplay.Items.Clear();
            LstDisplay.Items.Add("Three digit numbers divisible by the product of their digits");
            LstDisplay.Items.Add("");
            
            for (int number = 100; number <= 999; number++)
            {
                int product = 1;

                string num = Convert.ToString(number);

                for (int digit = 0; digit < num.Length; digit++)
                {
                    product *= int.Parse(num.Substring(digit, 1));
                }


                if (product != 0)
                {
                    if (number % product == 0)
                    {
                        LstDisplay.Items.Add(number.ToString() + "\t" +"is divisible by the product of its digits " +"\t" + product.ToString());
                    }
                }
            }
        
        }
    }
}