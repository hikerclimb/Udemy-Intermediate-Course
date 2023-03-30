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
using System.Text.RegularExpressions; //Need to use Regex

namespace WordCount
{
    public partial class FrmWord : Form
    {
        public FrmWord()
        {
            InitializeComponent();
        }

        //Here we reference an array of delimiters since the data we must parse 
        //isn't simply delimited by a space or comma. It uses several delimiters
        //char[] delimiterChars = { ' ', ':', '/' };
        //This will be used with the String.Split( ) method below  

        //... But we probably won't be able to list every possible delimiter
        //... So another solution is to use a C# Regular Expression
        //Regular expressions are used for text searching and more advanced text manipulation. 
        //A regular expression defines a search pattern for strings.
        //Regex is used to represent regular expressions and contains methods to 
        //match text, replace text or split text
        //You must add
        //using System.Text.RegularExpressions;
        //to implement the Regex method

        //https://zetcode.com/csharp/splitstring/
        //https://zetcode.com/csharp/regex/

        string[] lines;

        private void BtnWord_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Word Count Results" + Environment.NewLine + Environment.NewLine;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\words.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;            
            bool finished = false;

            //The RegexOptions.Compiled option specifies that the regular expression
            //is compiled to an assembly. This yields faster execution but increases 
            //startup time.
            
            //[^A-Za-z] ^ is Negation here we match everything except A to Z or a to z
            
            //Also recall the use of @ ... The Verbatim string literal
            //If a string contains @ as a prefix followed by double quotes
            //then the compiler identifies that string as a verbatim string 
            
            //The main advantage of the @ symbol is to ignore escape characters
            //and line breaks ...
            //recall \t \n 
            //... See string f = StartUpPath + @"\words.txt"; 
            //above
            
            var rx = new Regex(@"[^A-Za-z]", RegexOptions.Compiled);

            while (!finished)
            {
                WholeLine = r.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                    //lines = WholeLine.Split(' ');
                    //lines = WholeLine.Split(delimiterChars);
                    
                    lines = rx.Split(WholeLine); 

                    TxtDisplay.Text += WholeLine +"  ---->  " + " Number of words four letters or more  " + Count(lines) + Environment.NewLine;
                }

            }
        }

        private int Count(string [] TextLine)
        {
            int count = 0;

            for (int i=0;i<TextLine.Length;i++)
            {
                if (TextLine[i].Length > 3)
                {
                    count++;    
                }
            }

            return count;
        }
    }
}
