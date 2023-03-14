using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToleranceProblems
{
    public partial class FrmTolerance : Form
    {
        public FrmTolerance()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProblem1_Click(object sender, EventArgs e)
        {
            double num, den, y;

            TxtDisplay.Clear();
            
            for (int x = -10; x <= 10; x++)
            {
                num = Math.Pow(x, 3) - 4 * Math.Pow(x, 2);
                den = Math.Pow(x, 2) - 7 * x + 12;

                if (Math.Abs(den) <= 0.00001)
                {
                    TxtDisplay.Text += "x =  " + x.ToString() + "\t"+ " the denominator is 0 y is undefined" + Environment.NewLine;
                }
                else
                {
                    y = num / den;
                    TxtDisplay.Text+= " x = " + x.ToString() + "\t" + " y = " + y.ToString() + Environment.NewLine;
                }
            }
        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {
            double a, b, c;

            a=Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter the a value","Tolerance","",200,200));
            b=Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter the a value","Tolerance","",200,200));
            c=Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter the a value","Tolerance","",200,200));

            if (Math.Abs(Math.Pow(c, 2) - Math.Pow(a, 2) - Math.Pow(b, 2)) <= .00001)
            {
                MessageBox.Show("This is a right angled triangle");
            }
            else
            {
                MessageBox.Show("This is not a right angled triangle");
            }

        }

        private void BtnProblem3_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, y1, y2, y3;
            
            x1=Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter the x1 value","Tolerance","",200,200));
            y1=Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter the y1 value","Tolerance","",200,200));
            x2=Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter the x2 value","Tolerance","",200,200));
            y2=Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter the y2 value","Tolerance","",200,200));
            x3=Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter the x3 value","Tolerance","",200,200));
            y3=Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter the y3 value","Tolerance","",200,200));
                        
            if (Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)) <= .00001)
            {
                MessageBox.Show("The three points are collinear");
            }
            else
            {
                MessageBox.Show("The three points are not collinear");
            }
        }

        private void BtnProblem4_Click(object sender, EventArgs e)
        {
            double squareroot1;
            int squareroot2;

            TxtDisplay.Clear();
            
            for (int i = 1; i <= 1000; i++)
            {
                squareroot1 = Math.Sqrt(i);
                squareroot2 = (int)Math.Sqrt(i);

                if (Math.Abs(squareroot1 - squareroot2) <= 0.00001)
                {
                    TxtDisplay.Text += i.ToString() + " is a perfect square" + Environment.NewLine;
                }

            }
        }

        
    }
}