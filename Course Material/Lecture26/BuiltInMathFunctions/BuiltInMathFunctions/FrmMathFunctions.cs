using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiltInMathFunctions
{
    public partial class FrmMathFunctions : Form
    {
        public FrmMathFunctions()
        {
            InitializeComponent();
        }

        private void BtnMath_Click(object sender, EventArgs e)
        {
           

            TxtDisplay.Clear();

            //Math Functions

            TxtDisplay.Text += "Math.Abs( 23.7 ) = " + Math.Abs(23.7) + Environment.NewLine;
            TxtDisplay.Text += "Math.Abs( -23.7 ) = " + Math.Abs(-23.7) + Environment.NewLine;
            TxtDisplay.Text += "Math.Cos(0.0) = " + Math.Cos(0.0) + Environment.NewLine;
            TxtDisplay.Text += "Math.Cos( 45) radians = " + Math.Cos(45) + Environment.NewLine;
            TxtDisplay.Text += "Math.Cos( 45) degrees = " + Math.Cos(45*Math.PI/180) + Environment.NewLine;
            TxtDisplay.Text += "Math.Log( Math.E ) = " + Math.Log(Math.E) + Environment.NewLine;
            TxtDisplay.Text += "Math.Log10(100) = " + Math.Log10(100) + Environment.NewLine;
            TxtDisplay.Text += " Math.Sqrt(900.0) = " + Math.Sqrt(900.0) + Environment.NewLine;
            TxtDisplay.Text += "Math.Max(2.3, 12.7) = " + Math.Max(2.3, 12.7) + Environment.NewLine;
            TxtDisplay.Text += "Math.Min(-2.3, -12.7) = "+ Math.Min(-2.3, -12.7) + Environment.NewLine;
               

            
        }

        private void BtnApp_Click(object sender, EventArgs e)
        {
            //Simple Application using Math.Abs

            int total = 0;
            double avg;
            double distance;
            string inValue;

            int[] score = new int[11];

            // Values are entered
            for (int i = 1; i <= score.Length - 1; i++)
            {

                score[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter a score", "", ""));
            }

            // Values are summed
            for (int i = 1; i <= score.Length - 1; i++)
            {
                total += score[i];
            }

            avg = total / (score.Length-1);

            TxtDisplay.Text += Environment.NewLine;
            TxtDisplay.Text += "Average:" + avg.ToString("n2");

            // Output produced containing array
            // element and how far the value is
            // from the mean (absolute value).
            TxtDisplay.Text += Environment.NewLine;
            TxtDisplay.Text += "Score" + "\t" + " Dist. from Avg." + Environment.NewLine;

            for (int i = 1; i <= score.Length - 1; i++)
            {
                distance = Math.Abs((avg - score[i]));
                TxtDisplay.Text += score[i].ToString() + "\t" + distance.ToString("n2") + Environment.NewLine;
            }
        }
    }
}
