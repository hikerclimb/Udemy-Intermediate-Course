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

namespace BitsToAscii
{
    public partial class FrmBitsToAscii : Form
    {
        public FrmBitsToAscii()
        {
            InitializeComponent();
        }

        private void BtnBits_Click(object sender, EventArgs e)
        {

            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\bits.txt";

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
                    //pass the entire line of binary numbers to the Binary to Ascii method below 
                    TxtDisplay.Text += BtoA(line)  + Environment.NewLine;
                }
            }
        }

        private string BtoA(string b)
        {
            string text = "";
            string bin;
            int ascii;
            
            //Determine the number of unique characters to be extracted ... 8 bits make a byte (one ascii character)
            int NumOfChar = b.Length / 8;

            
            for (int i=1;i<=NumOfChar;i++)
            {
                bin = b.Substring((i - 1) * 8, 8);     //grab 8 bits at a time
                ascii =  (int) ConvertBinToAscii(bin); //send the bits off and return with the equivalent number (decimal) 
                text += (char)ascii;                   //convert this number (ascii value) to its equivalent string eg. ASCII 67 is C
            }                                          //concatentate (join) all the converts 8 bits on the current line to form the  
                                                       //decoded word 
            return text;
        }

        private double ConvertBinToAscii(string bin)
        {
            double total = 0; //need to make total here a decimal because we are using the Math.Pow function below which returns decimals

            for (int i=bin.Length-1;i>=0;i--)   //do you remember how to convert binary to decimal ?
            {                                   // 01000011 ----------------> starting from very right bit we have 1*2^0 + 1*2^1 + ...+ 1*2^6 
                total += int.Parse(bin.Substring(i, 1)) * Math.Pow(2, 7 - i);
            }

            return total;

        }
    }
}
