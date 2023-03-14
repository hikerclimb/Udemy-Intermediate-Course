using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReducedFractions
{
    public partial class FrmFractions : Form
    {
        public FrmFractions()
        {
            InitializeComponent();
        }

        string[] lines;

        private void BtnFractions_Click(object sender, EventArgs e)
        {

            TxtDisplay.Clear();
            TxtDisplay.Text = "Reduced Fractions Results" + Environment.NewLine + Environment.NewLine;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\fractions.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            int num;
            int den;
            bool finished = false;

            while (!finished)
            {
                WholeLine = r.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {                      
                        lines = WholeLine.Split(' ');
                        num=int.Parse(lines[0]);
                        den= int.Parse(lines[1]);   

                        TxtDisplay.Text += num.ToString() +  "  " + den.ToString() + "  In Reduced Fraction Form Equals " + Reduced(num,den) + Environment.NewLine;
                }                  

            }       
        }

        private string Reduced (int n, int d)
        {
            string result = "";
            string sign = " ";
            
            int g = 1;
            
            int whole;
            int fractionaln;
            int fractionald;       

            if (d == 0)
            {
                result = "Zero Denominator";
            }
            else
            {
                //if both numerator and denominator negative make them positive 
                if (d<0 && n<0)
                {
                    n = -n;
                    d = -d;
                }
                else if (d<0) //if the denominator is negative make the numerator negative instead
                {
                    n = -n;
                    d = -d;
                    sign = " -";
                }

                //we only want to mathematically deal with positives when we work out the GCD
                //so hold on to the sign for the final output
                if (n<0)
                {
                    n = -n;
                    sign = " -";
                }

                //find the greatest common divisor
                g = gcd(n, d);

                //Reduce the numerators and denominators by the GCD
                n = n / g;
                d = d / g;

                whole = n / d; //Here we are using integer division so 9/2=4 not 4.5
                fractionaln = n % d; //remainder calculation so 9%2 = 1
                fractionald = d;     //for 9/2 ... fractional d will be 2

                if (d==1)     //only whole part necessary
                {
                    result = sign + whole.ToString();
                }
                else if (n<d) //no whole part necessary 
                {
                    result = sign + n.ToString() + "/" + d.ToString();
                }
                else // whole  fractionaln/fractionald
                {
                    result = sign + whole.ToString() + " " + fractionaln.ToString() + "/" + fractionald.ToString();    
                }
            }

            return result;
        }

        //Here we use the Euclidean Algorithm to determine the GCD of any two numbers
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
    }
}
