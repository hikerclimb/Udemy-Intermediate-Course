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

namespace Uncrackable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUncrackable_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\crack.txt";

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

                    TxtDisplay.Text += "Potential Password: " + line + " Status: " + PassCheck(line).ToString() +  Environment.NewLine;

                }
            }
        }

        private string PassCheck(string p)
        {
            string status = "valid";
            int lower = 0;
            int upper = 0;
            int digit = 0;
            string s;
            char c;

            if (p.Length < 8 || p.Length > 12) //wrong length ... invalid right away
            {
                status = "invalid";
            }
            else
            {
                //iterate over all the characters in the potential password
                for (int i=0;i<p.Length;i++)
                {
                    //To make comparisons ie >= <= 
                    //we must convert the string extracted to a character type
                    s = p.Substring(i, 1);
                    c = Convert.ToChar(s);

                    //notice characters have single quotes as opposed to 
                    //strings which have double quotes
                    if (c>='a' && c<='z')
                    {
                        lower++;
                    }
                    else if (c>='A' && c<='Z' )
                    {
                        upper++;
                    }
                    else if (c>='0' && c<='9')
                    {
                        digit++;
                    }                        
                }

                if (lower>=3 && upper>=2 && digit>=1)
                {
                    status = "valid";                }
                else
                {
                    status = "invalid";
                }
            }            

            return status;
        }
    }
}
