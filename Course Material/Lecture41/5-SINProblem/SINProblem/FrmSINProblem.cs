using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SINProblem
{
    public partial class FrmSINProblem : Form
    {
        public FrmSINProblem()
        {
            InitializeComponent();
        }

        private void BtnSIN_Click(object sender, EventArgs e)
        {
            string SINCard;
            int digitdoubled;
            int total = 0;

            do
            {
                SINCard = Microsoft.VisualBasic.Interaction.InputBox("enter credit card number", "Credit Validation", "", 200, 200);
            }
            while (SINCard.Length != 9);

            for (int i = 1; i <=7; i+=2)        //2nd,4th,6th,8th
            {
                digitdoubled= int.Parse(SINCard.Substring(i, 1)) * 2;
                
                if (digitdoubled > 9)
                    digitdoubled -= 9;

                total += digitdoubled;
            }

            for (int i = 0; i <= 6; i += 2)     //1st,3rd,5th,7th
            {
                total += int.Parse(SINCard.Substring(i, 1));
            }

            //This determines the remainder when the total is
            //'subtracted from the next highest multiple of 10
            while (total>10)
            {
                total = total - 10;
            }

            total = 10 - total;
            
            string LastDigitOfSIN = SINCard.Substring(8);
            

            if (total == int.Parse(LastDigitOfSIN))
            {
                MessageBox.Show("valid","SIN Validation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("invalid", "SIN Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}