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



namespace Isogram
{
    public partial class FrmIsogram : Form
    {
        public FrmIsogram()
        {
            InitializeComponent();
        }

        private void BtnIsogram_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\words.txt";

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
                  
                    TxtDisplay.Text += line + " " + IsoStatus(line) + Environment.NewLine;
                  
                }
            }
        }

        private string IsoStatus(string w)
        {
            string status = "";

            //put word all in lowercase, just in case there are any capital letters
            string word = w.ToLower();
            //copy the characters in word into a Unicode character array
            var arrWord1 = word.ToCharArray();
            var arrWord2 = word.ToCharArray();

            //loop through each character/letter in the first array
            foreach(var letter1 in arrWord1)
            {
                //make sure it's a letter
                if (Char.IsLetter(letter1))
                {                
                    int count = 0;

                    //compare that current letter to each and every letter in the second array
                    //there should only be exactly one match ... count = 1
                    foreach(var letter2 in arrWord2)
                    {
                        if (Char.IsLetter(letter2))
                        {
                            if (letter1 == letter2)
                            {
                                count++;
                            }
                        }
                        else continue;
                    }
                    //if there was more than one match ... not an isogram
                    if (count >1)
                    {
                        status = "... is Not an Isogram";
                        return status;
                    }
                }
            }

            status = "... is an Isogram";
            return status;
        }
    }
}
