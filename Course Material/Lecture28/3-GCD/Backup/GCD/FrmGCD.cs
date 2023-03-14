using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GCD
{
    public partial class FrmGCD : Form
    {
        public FrmGCD()
        {
            InitializeComponent();
        }

        private int gcd(int m, int n)
        {
            int temp;
            int r;

            if (m < n)
            {
                temp = m;
                m = n;
                n = temp;
            }

            while (true)
            {
                r = m % n;
                if (r == 0)
                    break;

                m = n;
                n = r;
            }

            return n;
        }

        private int lcd(int x,int y)
        {
            //the lcd of two numbers x and y is x*y/gcd(x,y)

            return x*y/gcd(x,y);
        }


        private void BtnGCDTwo_Click(object sender, EventArgs e)
        {
            int a, b;

            a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter an positive integer", "GCD", "", 200, 200));
            b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter an positive integer", "GCD", "", 200, 200));

            MessageBox.Show("The GCD of " + a.ToString() + " and " + b.ToString() + "\n" + "is " + gcd(a, b).ToString());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGCDThree_Click(object sender, EventArgs e)
        {
            int a, b,c;

            a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter an positive integer", "GCD", "", 200, 200));
            b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter an positive integer", "GCD", "", 200, 200));
            c = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter an positive integer", "GCD", "", 200, 200));

            MessageBox.Show("The GCD of " + a.ToString() + " and " + b.ToString() +  " and " + c.ToString()+ "\n" + "is " + gcd(a, gcd(b,c)).ToString());
        }

        private void BtnLCM_Click(object sender, EventArgs e)
        {
            int a, b;

            a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter an positive integer", "LCD", "", 200, 200));
            b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter an positive integer", "LCD", "", 200, 200));

            MessageBox.Show("The LCD of " + a.ToString() + " and " + b.ToString() + "\n" + "is " + lcd(a, b).ToString());
        }
    }
}