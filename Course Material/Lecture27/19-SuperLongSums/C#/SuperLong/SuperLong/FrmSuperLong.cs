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

namespace SuperLong
{
    public partial class FrmSuperLong : Form
    {
        public FrmSuperLong()
        {
            InitializeComponent();
        }

        int[] digits = new int[101];

        private void BtnSuperLong_Click(object sender, EventArgs e)
        {
            
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\superlong.txt";

            StreamReader r = new StreamReader(f);

            string line1;
            string line2;
            bool finished = false;

            while (!finished)
            {
                line1 = r.ReadLine();

                if (line1 == null)
                {
                    finished = true;
                }
                else
                {
                    line2 = r.ReadLine();
                    TxtDisplay.Text += line1 + " + " + line2 + " = ";
                    TxtDisplay.Text += SuperLongAdd(line1, line2) + Environment.NewLine; 
                }
            }

            r.Close();

           
        }

        private string SuperLongAdd(string n, string r)
        {

            string totalstring = "";
            int len1, len2;

            for (int i=0;i<=100;i++)
            {
                digits[i] = 0;
            }

            len1 = n.Length;
            len2 = r.Length;


            //zero pad numbers to add so they have the exact same number of digits
            if (len1 < len2)
            {
                for (int i=1;i<=len2-len1;i++)
                {
                    n = "0" + n;
                }
            }
            else if (len1 > len2)
            {
                for (int i=1;i<=len1-len2;i++)
                {
                    r = "0" + r;
                }
            }

            len1 = n.Length - 1;
            len2 = r.Length - 1;

            //add the two numbers
            for (int i=len1;i>=0;i--)
            {
                digits[i] = int.Parse(n.Substring(i, 1)) + int.Parse(r.Substring(i, 1));
            }

            int carry = 0;
            int sum = 0;

            //now we worry about carry ... eg 7 + 7 would be stored in digits[i] as 14
            //we need to actually have 4 stored ... carry the 1
            for (int i=len1;i>=0;i--)
            {
                if (i==0)
                {
                    digits[i] = digits[i] + carry;
                }
                else
                {
                    sum = digits[i] + carry;
                    carry = sum / 10;
                    digits[i] = sum % 10;
                }
            }


            for(int i=0;i<=len1;i++)
            {
                totalstring += digits[i].ToString();
            }

            return totalstring;


        }
    }
}
