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

namespace FavouriteDigit
{
    public partial class FrmDigit : Form
    {
        public FrmDigit()
        {
            InitializeComponent();
        }

        int[] digits = new int[100];

        private void BtnDigit_Click(object sender, EventArgs e)
        {

            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\digits.txt";

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
                        TxtDisplay.Text += line + " largest digit is " + LargestDigit(line) + Environment.NewLine;                    
                }
            }
        }

        private int LargestDigit(string d)
        {
            int result = 0;
            int big = -100;    

            for (int i=0;i<d.Length;i++)
            {
                digits[i] = int.Parse(d.Substring(i, 1));
            }

            for (int i=0;i<d.Length;i++)
            {
                if (digits[i] > big)
                    big = digits[i];    
            }

            result = big;

            return result;
        }
    }
}
