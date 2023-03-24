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

namespace BobProblem
{
    public partial class FrmBob : Form
    {
        public FrmBob()
        {
            InitializeComponent();
        }

        private void BtnBob_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\bob.txt";

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
                        TxtDisplay.Text += line + "... Bob's Response is " + Response(line) + Environment.NewLine;                   
                }
            }
        }

        private string Response( string sentence)
        {
            string r = "";

            sentence = sentence.Trim(); //removes leading and trailing blank characters

            //Order of if statements is very important

            if (string.IsNullOrWhiteSpace(sentence))
            {
                r = "Fine. Be that way!";
            }
            // this if statement must come before the other two cases below
            //... otherwise soon as we found a ? we would display "Sure" even though the phrase is all capitalized
            //... or soon as we found that the phrase is all capitalized even though it might have a ? at the end we 
            //would incorrectly display "Whoa chill out"
            //... so the MOST SPECIFIC conditional must be first in line 
            else if (sentence.ToUpper() == sentence && sentence.ToLower() != sentence && sentence.EndsWith("?")) 
            {
                r = "Calm down, I know what I'm doing!";
            }
            else if (sentence.EndsWith("?"))
            {
                r = "Sure";
            }
            else if (sentence.ToUpper()==sentence && sentence.ToLower()!=sentence )
            {
                r = "Whoa, chill out!";
            }           
            else
            {
                r = "Whatever.";               
            }

            return r;
        }
    }
}
