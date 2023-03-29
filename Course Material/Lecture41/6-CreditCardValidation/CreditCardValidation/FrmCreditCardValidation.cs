using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CreditCardValidation
{
    public partial class FrmCreditCardValidation : Form
    {
        public FrmCreditCardValidation()
        {
            InitializeComponent();
        }
        
        // Account Number -> 8213267894
        // Last 9 digits  -> 213267894
        //                   2*2 + 2*1 + ..... 2*4 =84
        // If the first digit of the sum of the last nine digits doubled
        // is the check digit the account number is valid.
        // 1111111111 is valid
        
        private void BtnCredit_Click(object sender, EventArgs e)
        {
            string CreditCard;
            int Total9Digits = 0;

            do
            {
                CreditCard = Microsoft.VisualBasic.Interaction.InputBox("enter credit card number", "Credit Validation", "", 200, 200);
            }
            while (CreditCard.Length != 10);

            for (int i = 1; i < CreditCard.Length; i++)
            {
                Total9Digits += int.Parse(CreditCard.Substring(i, 1)) * 2;
            }

            string FirstDigitOf9DigitTotal = Total9Digits.ToString().Substring(0, 1);
            string FirstDigitOfCreditCard = CreditCard.Substring(0, 1);

            if (FirstDigitOf9DigitTotal == FirstDigitOfCreditCard)
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }

        private void BtnSchneider_Click(object sender, EventArgs e)
        {
            string code;
            int multiplier;
            int total;
            
            do
            {
                code = Microsoft.VisualBasic.Interaction.InputBox("enter credit card number", "Credit Validation", "", 200, 200);
            }
            while (code.Length != 5);

            multiplier=5;
            total=0;

            for (int i = 0; i <=3; i++)
            {
                total += int.Parse(code.Substring(i, 1))*multiplier ;
                multiplier--;
            }

            int remainder = total%11;
            int check=11-remainder;
                        
            if (check==int.Parse(code.Substring(4)))
            {
                MessageBox.Show("Valid","Schneider Code Validation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid","Schneider Code Validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}