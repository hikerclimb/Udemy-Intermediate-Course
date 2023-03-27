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

namespace ArmstrongNumbers
{
    public partial class FrmArmstrong : Form
    {
        public FrmArmstrong()
        {
            InitializeComponent();
        }

        private void BtnArmstrong_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\armstrong.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    TxtDisplay.Text += line + "  " + Armstrong(line) +  Environment.NewLine;
                    
                }
            }
        }

        private string Armstrong(string number)
        {
            string status = "no";

            int digit;
            double sum = 0;            
            int exp = number.Length;   //length of number to be used as exponent         
                                       //in Armstrong calculation 
            for (int i=0;i<number.Length;i++)
            {
                digit = int.Parse(number.Substring(i, 1));
                sum += Math.Pow(digit, exp);    
            }

            if (sum==int.Parse(number))
            {
                status = "yes";
            }

            return status;
        }
    }
}
