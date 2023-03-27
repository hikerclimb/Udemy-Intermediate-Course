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

namespace ParselTongue
{
    public partial class FrmParsel : Form
    {
        public FrmParsel()
        {
            InitializeComponent();
        }

        private void BtnParsel_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\parsel.txt";

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
                   
                    TxtDisplay.Text += line + " Translates to " + Translate(line) +  Environment.NewLine;
                   
                }
            }
        }

        private string Translate(string text)
        {
            string[] letters = new string[100];            
            string translation = "";

            //Check if first letter Capitalized
            //... we will use this at the end of the process
            //if true ... we capitalize the first letter 'h'
            //and lowercase the second letter (vowel)
            bool isCapsStatus = Char.IsUpper(text[0]);

            //store each letter into a 1D string array
            for (int i=0;i<text.Length;i++)
            {
                letters[i] = text.Substring(i, 1);            
            }

            //Begin the English to Parseltongue Translation

            bool wasVowel = false;
            bool wasCons = false;

            for (int j=0;j<text.Length;j++)
            {
                if (IsVowel(letters[j]))
                {
                    if (wasCons)
                    {
                        translation += "iss";
                    }
                    if (!wasVowel) 
                    {
                        translation += "h";
                    }

                    translation += letters[j];
                    wasCons = false;
                    wasVowel = true;
                }
                else
                {
                    translation += letters[j];
                    wasCons = true;
                    wasVowel = false;
                }
            }

            //End of word wrap up code
            
            if (wasCons)
            {
                translation += "iss";
            }

            if (isCapsStatus) //need to make new 'h' into a capital and the 2nd letter (vowel) lower case
            {
                translation = translation.Substring(0, 1).ToUpper()+  translation.Substring(1,1).ToLower() + translation.Substring(2);
            }

            return translation;
        }

        private bool IsVowel(string ch)
        {
            string letter = ch.ToLower();
            return (letter=="a"||letter=="e" || letter=="i" || letter=="o" || letter=="u" || letter=="y");
        }
    }
}
