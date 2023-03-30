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

namespace CryptoSquare
{
    public partial class FrmCrypto : Form
    {
        public FrmCrypto()
        {
            InitializeComponent();
        }

        //variables used to create square
        int column;
        int row;
        int padding;
        
        //size declared after column and row calculations below
        string [,] grid;
        
        //padding string
        string thepad = "                  ";

        private void BtnCrypto_Click(object sender, EventArgs e)
        {

            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\crypto.txt";

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
                    TxtDisplay.Text += "English Text  -> " +  line +  Environment.NewLine;
                    TxtDisplay.Text += "Encrypted Text -> " + CryptoEncode(line) +Environment.NewLine;
                }
            }
        }

        private string CryptoEncode (string text)
        {
            string encoded = "";

            //Put all text in lowercase and remove spaces and punctuations
            string NormalizedText = NormalizeText(text);

            //Determine dimensions for square and padding if necessary
            //we have declared the variables column,row,padding as public variables 
            //near top of code
            CalculateSquareParams(NormalizedText);
            
            //add some string padding to end of text if necessary
            if (padding >0)
            {
                NormalizedText = NormalizedText + thepad.Substring(1, padding);
            }           

            //declare size of 2d array
            grid = new string [row+1, column+1];

            encoded = CryptoSquare(NormalizedText, grid,row,column);

            return encoded;
        }

        private string NormalizeText(string t)
        {
            string newt = "";
            string lowert = t.ToLower();

            for (int i=0;i<lowert.Length;i++)
            {
                string c = lowert.Substring(i, 1);
                char tempchar = Convert.ToChar(c);

                //only keep letters
                if (tempchar >='a' && tempchar <='z')
                {
                    newt += c;
                }
            }

            return newt;
        }

        private void CalculateSquareParams(string plaintext)
        {
            column = (int)Math.Ceiling(Math.Sqrt(plaintext.Length));  //  sqrt(54)=7.3 ... 8
            row = (int)Math.Round((double)plaintext.Length / column); //  54/8=6.75 ...... 7
            padding = column * row - plaintext.Length;  //56-54=2
        }

        private string CryptoSquare(string plaintext, string [,] g,int rt, int ct)
        {
            string CipheredText = "";

            //counter used by Substring command to extract letters from plaintext and place them
            //in the 2d array
            int i = 0;

            //Fill 2d array row wise with letters from plaintext
            for (int r=1;r<=rt;r++)
            {
                for (int c=1;c<=ct;c++)
                {
                    g[r, c] = plaintext.Substring(i, 1);
                    i++;
                }
            }

            // \used to place actual quotes in CipherText string
            CipheredText += "\"";

            //Create cipheredtext columnwise from 2d array 
            for (int c=1;c<=ct;c++)
            {
                for (int r=1;r<=rt;r++)
                {
                    CipheredText += g[r, c];
                }

                //at end of each column add blank to separate sections
                if (c<ct)
                    CipheredText += " ";
            }

            CipheredText += "\"";

            return CipheredText;
        }
    }
}
