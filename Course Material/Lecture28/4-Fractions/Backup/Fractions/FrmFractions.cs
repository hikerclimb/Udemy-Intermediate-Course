using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fractions
{
    public partial class FrmFractions : Form
    {
        public FrmFractions()
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

        private void BtnProblem1_Click(object sender, EventArgs e)
        {
            int a, b, c;

            MessageBox.Show("Converting an mixed fractions of the form a b/c to improper");
             
            a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a", "Improper Fractions", "", 200, 200));
            b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter b", "Improper Fractions", "", 200, 200));
            c = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter c", "Improper Fractions", "", 200, 200));

            int numerator = a * c + b;
            int denominator = c;
            int d = gcd(numerator, denominator);

            int reducedn = numerator / d;
            int reducedd = denominator / d;

            MessageBox.Show("The reduced improper fraction is " + reducedn.ToString() + "/" + reducedd.ToString());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {
            int a, b, c,d;

            MessageBox.Show("Adding two fractions of the form a/b + c/d");

            a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a", "Adding Fractions", "", 200, 200));
            b = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter b", "Adding Fractions", "", 200, 200));
            c = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter c", "Adding Fractions", "", 200, 200));
            d = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter c", "Adding Fractions", "", 200, 200));
            
            int numerator = a * d + b*c;
            int denominator = b*d;
            int divisor = gcd(numerator, denominator);

            int reducedn = numerator / divisor;
            int reducedd = denominator / divisor;

            MessageBox.Show("The sum of the fractions is " + reducedn.ToString() + "/" + reducedd.ToString());
        }
    }
}