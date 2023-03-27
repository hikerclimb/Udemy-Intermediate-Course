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

namespace Acronyms
{
    public partial class FrmAcronym : Form
    {
        public FrmAcronym()
        {
            InitializeComponent();
        }

        string[] lines;


        //String.Split can use multiple separator characters.
        //Here we store all the possible separators: spaces, a dash, and back slash, 
        //in an char array to be accessed below
        char[] Separators = { ' ', '-', '/' };

        private void BtnAcronyms_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Acronyms" + Environment.NewLine + Environment.NewLine;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\acronym.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            string FirstChar;
            int nw;
            
            bool finished = false;

            while (!finished)
            {
                string acronym = "";

                WholeLine = r.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                   
                    //recall the char Separator declaration above
                    lines = WholeLine.Split(Separators);
                                        
                    nw = lines.Length;//number of words to work through to create acronym

                    for (int c = 0; c < nw; c++)
                    {
                        FirstChar = lines[c].Substring(0, 1); //Take the first letter of each word in the line
                        acronym+=FirstChar;                   //and concatenate them 
                                                                
                    }

                    TxtDisplay.Text += WholeLine + "--->" + acronym + Environment.NewLine;

                }

            }

            r.Close();
        }
    }
}
