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


namespace HarshadNumbers
{
    public partial class FrmHarshad : Form
    {
        public FrmHarshad()
        {
            InitializeComponent();
        }

        private void BtnHarshad_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\harshad.txt";

            StreamReader r = new StreamReader(f);

            string line1;
            string line2;
            bool finished = false;

            while (!finished)
            {
                line1 = r.ReadLine();

                if (line1 == null)
                {
                    finished = true;
                }
                else
                {
                    line2 = r.ReadLine();
                    {  
                        TxtDisplay.Text += " For the range of numbers between " +line1+ " and  " +  line2 + " the longest consecutive sequence of Harshad Numbers is " + HarshadNumbers(int.Parse(line1),int.Parse(line2)) + Environment.NewLine;
                    }
                }
            }
        }

        private int HarshadNumbers (int start,int end)
        {
            int longestRun = 0;
            int currentRun = 0;

            for (int i=start;i<=end;i++)
            {
                if (i% getDigitSum(i)==0)
                {
                    currentRun++;
                    longestRun = Math.Max(currentRun, longestRun);
                }
                else
                {
                    currentRun = 0; //reset currentRun once we don't get a Harshad Number
                }
            }

            return longestRun;
        }

        private int getDigitSum(int n)
        {
            int sum = 0;

            string sn = n.ToString();

            //find the sum of the digits by first converting the number in question into a string
            //so that we can pull apart each digit using the string function Substring()
            for (int i=0;i<sn.Length;i++)
            {
                sum += int.Parse(sn.Substring(i, 1));
            }

            return sum;
        }
    }
}
