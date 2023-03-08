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

namespace SimpleChecksum
{
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        string[] lines;
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        private void BtnCheck_Click(object sender, EventArgs e)
        {

            TxtDisplay.Clear();
            TxtDisplay.Text = "Checksum Results" + Environment.NewLine + Environment.NewLine;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\numbers.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            bool finished = false;

            string num;
            string chk;

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

                    num = lines[0];
                    chk = lines[1];

                    TxtDisplay.Text += num + " " + chk + " " + CheckNumber(num,chk) + Environment.NewLine;
                }

            }

            r.Close();

        }

        private string CheckNumber(string n, string c)
        {
            string result = "error";

            int sum = 0;
            int pos = 0;
            
            string sumString;
            string letter;

            while(true)
            {
                //add up all the digit in the current number
                for (int i=0; i < n.Length; i++)
                {
                    sum += int.Parse(n.Substring(i, 1));
                }

                //put back current sum to string and determine its length
                //if it's a single digit number then stop
                sumString = sum.ToString();
                if (sumString.Length == 1)
                    break;

                //... otherwise reset the n (string container) to the new current number total
                //re-initialize sum back to zero
                n = sumString;
                sum = 0;
            }

            //... finally done, we have a single digit number (currently in string format)
            //... convert it to an integer and determine which letter of the alphabet it matches
            //... realize pos will be numbers like 1,2,3 etc ... but to reference letters 
            //in our alphabet string first letter 'a' is actually in position 0 so 
            //thats why we have pos-1
            pos= int.Parse(sumString);
            letter= alphabet.Substring(pos-1,1);

            if (letter.ToUpper()==c)
            {
                result = "Match";
            }
            else
            {
                result = "Error";
            }

            return result;
        }
    }
}
