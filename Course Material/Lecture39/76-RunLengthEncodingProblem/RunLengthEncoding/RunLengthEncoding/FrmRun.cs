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

namespace RunLengthEncoding
{
    public partial class FrmRun : Form
    {
        public FrmRun()
        {
            InitializeComponent();
        }

        private void FrmRun_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Run Length Encoding Problem");
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\rle.txt";

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
                    TxtDisplay.Text += line +  Environment.NewLine;
                    TxtDisplay.Text += "Encoded -> " + Encode(line) + Environment.NewLine;
                }
            }
        }

        private string Encode (string code)
        {
            //This program uses StringBuilder to build up a buffer of characters. 
            //We call Append() to add more data to our StringBuilder.

            //Here we create a StringBuilder class instance (an object) called encoded
            //It begins its existence emtpy, with no buffered characters
            var encoded = new StringBuilder();

            for (int charIndex=0;charIndex<code.Length;charIndex++)
            {
                int count = 1;

                while (charIndex +1 < code.Length && code.Substring(charIndex,1)==code.Substring(charIndex+1,1))
                {
                    charIndex++;
                    count++;
                }

                //Here we call Append where the arguments are concatenated
                //There also exists an AppendLine method which would append a newline
                if (count>1)
                {
                    //$ is short-hand for String.Format and is used with string interpolations (used to construct strings) 
                    //An interpolated string expression creates a string by replacing the contained expressions with the 
                    //ToString represenation of the expressions’ results.
                    encoded.Append($"{count}{code.Substring(charIndex, 1)}");
                }
                else
                {
                    encoded.Append(code.Substring(charIndex, 1));
                }
            }

            return encoded.ToString();
        }
    }
}
