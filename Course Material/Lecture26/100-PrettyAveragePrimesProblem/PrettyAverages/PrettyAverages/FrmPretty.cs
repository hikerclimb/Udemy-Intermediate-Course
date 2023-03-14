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

namespace PrettyAverages
{
    public partial class FrmPretty : Form
    {
        public FrmPretty()
        {
            InitializeComponent();
        }

        //We are finding 2 primes A and B such that N = (A+B)/2
        //... or 2N = A + B
        

        int[] numbers = new int[100];

        private void BtnPretty_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\pretty.txt";

            StreamReader r = new StreamReader(f);

            string line;
            int numLines;
           
            line = r.ReadLine();
            numLines = int.Parse(line);

            for (int i = 0; i < numLines; i++)
            {
                numbers[i]= int.Parse(r.ReadLine());
            }

            //We will use a loop variable j which starts at 2 in order to find
            //A and B which have a sum of 2N. If we find a j that is prime and
            //we see that (2N-j) is also prime we have found our A and B.

            int doubled = 0;
            
            for (int i=0;i<numLines;i++)
            {
                doubled = numbers[i] * 2;

                for (int j=2;j<doubled;j++)
                {
                    if (isPrime(j) && isPrime(doubled-j))
                    {
                        TxtDisplay.Text += "For " + numbers[i].ToString() +
                            " The values for A and B are " + j.ToString() + " and " + (doubled - j).ToString() + Environment.NewLine;                             
                    }
                }
            }
               
        }

        //This method is used  to determine if a given 
        //number is prime. You only need to check up to the square root of 
        //the given number to determine if it is prime or not.
        private bool isPrime(int n)
        {
            int max = (int)Math.Sqrt(n);

            for (int i=2;i<=max;i++)
            {
                if (n%i==0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
