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

namespace Pangram
{
    public partial class FrmPan : Form
    {
        public FrmPan()
        {
            InitializeComponent();
        }

         

        private void BtnPan_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\pangram.txt";

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
                        TxtDisplay.Text += line + "  " + PanStatus(line)  + Environment.NewLine;
                }
            }
        }

        private string PanStatus(string sentence)
        {
            //This first solution implements a array flag technique
            //which tracks if a letter of the alphabet occured in the sentence

            int[] PanFlag = new int[26];

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string letter;
            int pos;

            string status = "YES";

            //convert the sentence to lower case and get rid of blanks
            string lowercase = sentence.ToLower();

            string newlowercase = "";

            for (int i=0;i<lowercase.Length;i++)
            {
                letter = lowercase.Substring(i, 1);
                if (letter !=" ")
                {
                    newlowercase = newlowercase + letter;
                }
            }

            //Pull out each letter from the sentence
            //Determine it's position in the alphabet 
            //Then indicate that letter (position) has been picked by
            //assigning that location (position) a value of one
            //eg ... found the 'h' in "The quick brown fox"
            //so position of h is 7 (remember we start at 0) ... 
            //so PanFlag[7]=1
            for (int i=0;i<newlowercase.Length;i++)
            {
                letter = newlowercase.Substring(i, 1);
                pos = alphabet.IndexOf(letter);
                PanFlag[pos] = 1;
            }

            //... and finally we loop through the entire alphabet to make sure
            //each position (letter) has a flag status of 1
            //if we find a flag status of 0 that means the sentence did not 
            //use all the letters of the alphabet
            for (int i=0;i<alphabet.Length;i++)
            {
                if (PanFlag[i]==0)
                {
                    status = "NO";
                    break;
                }
            }

            return status;
        }

        private void BtnPan2_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\pangram.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;
            bool status;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    status = PanStatusNew(line);
                    if (status)
                    {
                        TxtDisplay.Text += line + " YES" +   Environment.NewLine;
                    }
                    else
                    {
                        TxtDisplay.Text += line + " NO" + Environment.NewLine;
                    }
                    
                }
            }
        }

        private bool PanStatusNew(string sentence)
        {
            //This second technique is much shorter but implements 
            //some slightly more advanced commands, including 
            //the for...each loop and the Contains method           
            
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            
            string lowercase = sentence.ToLower();

            //Here we are doing the opposite of the first method
            //We start with the alphabet and check for the existence of that
            //letter in the sentence using the Contain method
            //If we can't find the current letter in the sentence we return
            //false to indicate that this sentence is NOT a pangram
            //... otherwise it is a pangram
            foreach (var letter in alphabet)
            {
                if (!lowercase.Contains(letter))
                    return false;
            }

            return true;
            
        }
    }
}
