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

namespace XORproblem
{
    public partial class FrmXOR : Form
    {
        public FrmXOR()
        {
            InitializeComponent();
        }

        string first;
        string message;

        int firstbyte;
        int[] messagebytes = new int[101];

        byte key;
        byte[] newmessagebytes = new byte[101];

        private void BtnXOR_Click(object sender, EventArgs e)
        {
            string[] lines;

            string[] snumber = new string[100];
            double[] number = new double[100];
            int[] p = new int[100];

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\code.txt";
            StreamReader read = new StreamReader(f);

            string WholeLine;
         
            TxtDisplay.Clear();
            

            first = read.ReadLine();           //Reads in the "H" (assuming we are using the initial student data ... from pdf problem)
            firstbyte = Convert.ToChar(first); //can't work with strings when using XOR so we convert to an integer using ToChar
                                               //so firstbyte = 72 
            
            WholeLine = read.ReadLine();

            //pull apart each byte
            lines = WholeLine.Split(' ');

            //determines the number of byte (8 bits)  codes
            int u = lines.Length;

            //Take each byte and convert it to a integer so we can work on it with XOR command
            for (int y = 0; y < u; y++)
            {
                messagebytes[y] = (int) bintodec(lines[y]);

            }

            //we need the key lets use the first byte from above (72) and figure it out
            //so ... messagebytes[0] is 139 and we XOR it to 72 and get 195 (the computer is doing some binary stuff behind our backs)
            key = (byte)(messagebytes[0] ^ firstbyte);

            //now that we have the key we can figure out the secret message 
            message = "";
            for(int y=0;y<u;y++)
            {
                newmessagebytes[y] = (byte)(messagebytes[y] ^ key);   //first we determine the answer as a number (ASCII code) ...first one is 72
                message += (char)newmessagebytes[y];                  //then (char) converts it to character string .... "H"
            }

            TxtDisplay.Text += first + Environment.NewLine;
            for (int y = 0; y < u; y++)
            {
                TxtDisplay.Text += lines[y] + " ";
            }
            TxtDisplay.Text += Environment.NewLine;
            for (int y=0;y<u;y++)
            {
                TxtDisplay.Text += messagebytes[y] + " " ;
            }
            TxtDisplay.Text += Environment.NewLine;
            TxtDisplay.Text += message;

        }

        private double bintodec(string a)
        {
            double dec = 0;
            for (int b=a.Length-1; b>=0;b--)
            {
                dec += int.Parse(a.Substring(b, 1)) * Math.Pow(2, a.Length - 1 - b);
            }

            return dec;
        }
            
    }
}
