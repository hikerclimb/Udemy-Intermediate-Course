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

namespace Atbash
{
    public partial class FrmAtbash : Form
    {
        public FrmAtbash()
        {
            InitializeComponent();
        }

        string alpha = "abcdefghijklmnopqrstuvwxyz";
        string reverse = "zyxwvutsrqponmlkjihgfedcba";

        private void BtnCipher_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\atbash.txt";

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
                    TxtDisplay.Text += "original text " + line + Environment.NewLine;
                    TxtDisplay.Text += "ciphered text " + AtbashCipher(line.ToLower()) + Environment.NewLine;
                    TxtDisplay.Text += Environment.NewLine;
                }
            }
        }

        private string AtbashCipher(string txt)
        {
            string cipher = "";
            int c = 0; //letter count... when we get to a multiple of 5
                       //we add a space 
            for (int i=0;i<txt.Length;i++)
            {
                string letter = txt.Substring(i,1); //extract letter from original message
                int pos = alpha.IndexOf(letter);    //find it's position in the alphabet

                if (pos >= 0) //only worry about the alphabet... no punctuations
                {

                    c++; //count the current letter

                    if (c % 5 == 0)//mulitple of ? ... add a space
                    {
                        cipher += reverse.Substring(pos, 1) + " ";
                    }
                    else
                    {
                        cipher += reverse.Substring(pos, 1); //go to the exact same position
                    }                                        //in the reversed alphabet
                                                             //and take that 
                }                
            }

            return cipher;
        }
    }
}
