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

namespace PatternMatching
{
    public partial class FrmPattern : Form
    {
        public FrmPattern()
        {
            InitializeComponent();
        }

        string[] lines;

        private void BtnPattern_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Pattern Matching Results" + Environment.NewLine + Environment.NewLine;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\pattern.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            string word1;
            string word2;
            
            bool finished = false;

            while (!finished)
            {
                WholeLine = r.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                    lines = WholeLine.Split(' ');                    
                    word1 = lines[0];
                    word2 = lines[1];                    

                    TxtDisplay.Text += word1 + " " + word2 + " -> " + CheckMatch(word1.ToLower(),word2.ToLower()) + Environment.NewLine;
                }

            }
        }

        private string CheckMatch (string w1,string w2)
        {
            string c = "bcdfghjklmnpqrstvwxyz";
            string v = "aeiou";
            string r;
            string result = "Different";

            //Replace all consonants in first word with C
            for (int i=0;i<c.Length;i++)
            {
                r = c.Substring(i, 1);
                w1 = w1.Replace(r, "C");
            }
            //Replace all vowels in first word with V
            for (int i=0;i<v.Length;i++)
            {
                r=v.Substring(i, 1);
                w1=w1.Replace(r, "V");
            }

            //------------------------------------------------------

            //Replace all consonants in second word with C
            for (int i = 0; i < c.Length; i++)
            {
                r = c.Substring(i, 1);
                w2 = w2.Replace(r, "C");
            }
            //Replace all vowels in first word with V
            for (int i = 0; i < v.Length; i++)
            {
                r = v.Substring(i, 1);
                w2 = w2.Replace(r, "V");
            }

            //Check if Consonant Vowel patterns match
            if (w1 == w2)
            {
                result = "Same";
            }

            return result;
        }
    }
}
