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

namespace BinaryBest
{
    public partial class FrmBinary : Form
    {
        public FrmBinary()
        {
            InitializeComponent();
        }

        string[] lines;
        int n;
        string NumberBase;
        string NumberBinary;

        private void BtnBinary_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Conversion Results" + Environment.NewLine + Environment.NewLine;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\binary.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
                       
            WholeLine = r.ReadLine();

            n = int.Parse(WholeLine);

            for (int i=1;i<=n;i++)
            {
                WholeLine = r.ReadLine();

                lines = WholeLine.Split(' ');

                NumberBase = lines[0];
                NumberBinary = lines[1];

                TxtDisplay.Text += NumberBase + " " + NumberBinary +  " Result in base " + NumberBase + " is " + Convert(NumberBinary,int.Parse(NumberBase)) + Environment.NewLine;              
            }                      

            r.Close();
        }

        private string Convert(string s, int b)
        {
            string result = "";

            //First we convert the binary number to decimal 
            double n = 0;
            int power = 0;
            for (int i=s.Length-1;i>=0;i--)
            {
                n += int.Parse(s.Substring(i, 1)) * Math.Pow(2, power);
                power++;
            }

            if (b==10) //if base is 10 we are done
            {
                result = n.ToString(); ;
            }
            else
            {
                // otherwsie convert to new base
                // this involves repeated divisions by the base
                // determining quotients and remainders
                // until the quotient is zero
                int quotient = 0;
                int remainder = 0;
                int newNumber = (int)n; //n was a double when we converted the binary to a decimal
                 
                do
                {
                    quotient = newNumber / b;
                    remainder = newNumber % b;
                    result = remainder.ToString() + result;
                    newNumber = quotient;

                } while (newNumber != 0);

            }

            return result;
        }
    }
}
