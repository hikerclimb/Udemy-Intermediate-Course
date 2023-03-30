using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VIN
{
    public partial class FrmVIN : Form
    {
        public FrmVIN()
        {
            InitializeComponent();
        }

        private void BtnVIN_Click(object sender, EventArgs e)
        {
            string vin;
                        
            string digitassign;
            string[] digits = new string[17];

            int sumofDigits=0;
            int checkDigit;

            vin = Microsoft.VisualBasic.Interaction.InputBox("Please enter VIN number including *", "", "", 300, 300);
            digitassign=Microsoft.VisualBasic.Interaction.InputBox("Please enter digital assignment string including *", "", "", 300, 300);

            for (int i = 0; i < vin.Length; i++)
            {                
                digits[i] = digitassign.Substring(i, 1);
            }

            int c = 0;
            int multiplier=8;

            while (c < 17)
            {
                if (c == 7)
                {
                    multiplier = 10;                   
                }

                if (c <= 7 || c >= 9)
                {
                    sumofDigits += multiplier * (int.Parse(digits[c]));
                    multiplier -= 1;
                    c++;
                }
                else
                {
                    c++;
                }
            }

            checkDigit = sumofDigits % 11;

            string check="";

            if (checkDigit == 10)
            {
                check = "X";
            }
            else
            {
                check = checkDigit.ToString();
            }


            string newvin= vin.Replace("*", check);

            MessageBox.Show("The check digit is " + check);
            MessageBox.Show("The full VIN is " + newvin);
                

        }
    }
}