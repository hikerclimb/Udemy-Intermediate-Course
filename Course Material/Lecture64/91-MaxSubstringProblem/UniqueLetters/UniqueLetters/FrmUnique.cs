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

namespace UniqueLetters
{
    public partial class FrmUnique : Form
    {
        public FrmUnique()
        {
            InitializeComponent();
        }

        //You are given a string of capital characters with no spaces.
        //Determine the length of the longest sub-string within the string
        //that contains no duplicate characters.
        //TESTIFYING    --> ESTIFY is the longest, which produces six.
        //FRIGHTFUL     --> RIGHTFUL is longest, which produces eight
        //TTTT		   --> T is longest, which produces one
        //EASILY		   --> EASILY is all unique, so result is six

        private void BtnUnique_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\unique.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            int maxLength;
            string sub;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    maxLength = 0;
                    
                    //Start extracting substrings
                    for (int i = 0; i < line.Length; i++)
                    {
                        for (int j=i+1;j<=line.Length; j++)
                        {
                            sub= line.Substring(i,j-i); //start,end-start
                                                        //simulates from ... to string extraction

                            //Check if current substring has any duplicates
                            if (Duplicates(sub))
                            {
                                break;
                            }
                            if (sub.Length > maxLength) //no duplicates found in current substring
                            {                           //see if it's length is greater than the current max
                                maxLength = sub.Length; 
                            }
                        }
                    }

                    TxtDisplay.Text += line +   "     --- >  Maximum Sub Length " + maxLength.ToString() + Environment.NewLine;                    
                }
            }
        }

        private bool Duplicates(string s)
        {
            bool status = false;
            string c = "";

            //A Dictionary is a generic collection which is generally used to store key/value pairs.
            //A Dictionary is defined under System.Collection.Generics namespace.
            //It is dynamic in nature which means the size of the dictionary grows according to the need.

            Dictionary<string, bool> dups = new Dictionary<string, bool>();

            for (int i = 0; i < s.Length; i++)
            {
                c = s.Substring(i, 1);
                if (dups.ContainsKey(c)) //checks for duplicate in Dictionary list
                {                        //if duplicate found get out of loop and return   
                    status = true;
                    break;
                }

                dups.Add(c, true);      //no duplicate found yet in loop
                                        //so add current to dictionary with bool value true
            } 

            return status;
        }
    }
}
