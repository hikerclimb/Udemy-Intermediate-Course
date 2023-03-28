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

namespace SupplementaryStringProblems
{
    public partial class FrmSupplementary : Form
    {
        public FrmSupplementary()
        {
            InitializeComponent();
        }

        int[] ChFreq = new int[256];

        private void BtnMax_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\maxchar.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;
            

            while (!finished)
            {

                for (int i=0;i<=255;i++)
                {
                    ChFreq[i] = 0;
                }

                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    int p= DetermineGreatestFreq(line);
                    TxtDisplay.Text += line +  Environment.NewLine;
                    TxtDisplay.Text += "The letter " + (char)p + " had the highest frequency of " + ChFreq[p] + Environment.NewLine; ;
                    TxtDisplay.Text += Environment.NewLine;               
                }
            }
        }

        private int DetermineGreatestFreq(string sent)
        {
            int max = -1;
            int pos = -1;

            for (int i=0;i<sent.Length;i++)
            {
                char c = Convert.ToChar(sent.Substring(i, 1));
                int ascii = (int)c; //casting here is actually redundant 
                ChFreq[ascii]++;
            }

            for (int i=0;i<=255;i++)
            {
                if (i != 32) //don't count spaces
                {
                    if (ChFreq[i] > max)
                    {
                        max = ChFreq[i];
                        pos = i;
                    }
                }
                    
            }


            return pos;
        }

        private void BtnArmstrong_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text += "Numbers between 1 and 500 that are Armstrong numbers";
            TxtDisplay.Text += Environment.NewLine;

            for (int number = 1; number <= 500; number++)
            {
                double sum = 0;

                string num = Convert.ToString(number);

                for (int digit = 0; digit < num.Length; digit++)
                {
                    sum += Math.Pow(int.Parse(num.Substring(digit, 1)), 3);
                }


                if (sum == number)
                {                   
                    TxtDisplay.Text += number.ToString() + " is an Armstrong Number";
                    TxtDisplay.Text += Environment.NewLine;                    
                }
            }
        }
    }
}
