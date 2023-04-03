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

namespace CryptoAnalysis
{
    public partial class FrmCrypto : Form
    {
        public FrmCrypto()
        {
            InitializeComponent();
        }

        char[] letters = new char[27];
        int[] count = new int[27];

        private void BtnCrypto_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\crypto.txt";
            StreamReader read = new StreamReader(f);

            string WholeLine;
            string CWholeLine;

            //store A-Z into letters[] array ... used later in our sort
            // (int) 'A' is 65
            // (char) 65 is 'A'

            for (int i = 0; i <= 25; i++)
            {
                letters[i + 1] = (char)((int)'A' + i);
            }

            //initialize 1d array counter
            for (int i = 1; i <= 26; i++)
            {
                count[i] = 0;
            }             
            
            //read in number of lines in text to analyze
            WholeLine = read.ReadLine();

            int number = int.Parse(WholeLine);

            for (int i = 1; i <= number; i++)
            {

                WholeLine = read.ReadLine();
                CWholeLine = WholeLine.ToUpper(); //convert all the text to uppercase
                                                  //makes it easier to count  
                for (int j=0;j<CWholeLine.Length;j++)
                {
                    string letter = CWholeLine.Substring(j, 1);
                    char tempchar = Convert.ToChar(letter);
                    if (tempchar >='A'&& tempchar <='Z')  //can't perform this comparison as pure strings must be a char
                    {
                        count[tempchar + 1 - 'A']++; //A should be count[1] .... 66-65 (ASCII codes)
                    }
                }                

            }

            //now sort results using exchange sort
            for (int i = 1; i <= 25; i++)
            {
                for (int j = i + 1; j <= 26; j++)
                {
                    if (count[i] < count[j])
                    {
                        char t1 = letters[i];       //remember need to swap both the count and the letters
                        letters[i] = letters[j];    //ie multi field sort
                        letters[j] = t1;

                        int t2 = count[i];
                        count[i] = count[j];
                        count[j] = t2;
                    }
                }
            }

            for (int i=1;i<=26;i++)
            {
                if (count[i]>0)             // only display the count of letters with at least one occurence
                {
                    TxtDisplay.Text += letters[i] + " " + count[i] + Environment.NewLine;
                }
            }

        }
    }
}
