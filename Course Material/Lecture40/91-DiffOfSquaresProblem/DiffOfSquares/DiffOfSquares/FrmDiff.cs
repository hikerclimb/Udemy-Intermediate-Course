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

namespace DiffOfSquares
{
    public partial class FrmDiff : Form
    {
        public FrmDiff()
        {
            InitializeComponent();
        }

        string[] lines;

        private void BtnDiff_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\numbers.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            int lower;
            int upper;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    lines = line.Split(' ');
                    lower = int.Parse(lines[0]);
                    upper = int.Parse(lines[1]);

                    TxtDisplay.Text += "Range -> " + lower.ToString() + " " +upper.ToString() +  Environment.NewLine;
                    TxtDisplay.Text += "--------------------------------------------------------------" + Environment.NewLine;
                    Difference(lower, upper);
                }
            }
        }

        private void Difference(int l, int u)
        {
            bool flag = false; //used to determine if a range did not have any differences greater than 150

            for (int num=l;num<=u;num++)
            {
                               
                int diff = 0;

                int Sum1 = 0;
                int Sum1Squared = 0;
                int Sum2 = 0;

                string snum = num.ToString(); //convert num in for loop to a string so that we can 
                                              //extract each digit using Substring                

                for (int i=0;i<snum.Length;i++)
                {
                    Sum1 += int.Parse(snum.Substring(i, 1));
                }

                Sum1Squared = Sum1 * Sum1;

                for (int i=0;i<snum.Length;i++)
                {
                    Sum2 += (int) Math.Pow(int.Parse(snum.Substring(i, 1)), 2);
                }

                diff = Sum1Squared - Sum2;

                if (diff>150)
                {
                    TxtDisplay.Text += num + " has a difference of " + diff.ToString() + Environment.NewLine;
                    flag = true;
                }
            }

            if (flag==false)
            {
                TxtDisplay.Text += "No differences greater than 150 for this range" + Environment.NewLine;
            }

            TxtDisplay.Text += "---------------------------------------------------------------" + Environment.NewLine;
            
        }
    }
}
