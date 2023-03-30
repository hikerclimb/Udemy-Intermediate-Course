using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SingleDigit
{
    public partial class FrmSingleDigit : Form
    {
        public FrmSingleDigit()
        {
            InitializeComponent();
        }

        private void BtnSingleDigit_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            TxtDisplay.Text = "Single Digit Results" + Environment.NewLine + Environment.NewLine;
            
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\onedigit.txt";

            StreamReader r = new StreamReader(f);

            string number;
            bool finished = false;

            while (!finished)
            {
                number = r.ReadLine();

                if (number == null)
                {
                    finished = true;
                }
                else
                {
                    TxtDisplay.Text += "Sum of digits in " + number + " = " + One(number) + Environment.NewLine; 
                }
            }

            r.Close();

        }

        private string One(string n)
        {

            int SumOfDigits;

            string NewNumberString = n;

            while (true)
            {
                if (NewNumberString.Length == 1)
                    break;

                SumOfDigits = 0;

                for (int i = 0; i < NewNumberString.Length; i++)
                {
                    SumOfDigits += int.Parse(NewNumberString.Substring(i, 1));
                }

                NewNumberString = SumOfDigits.ToString();
            }

            return NewNumberString;
        }
    }
}