using Microsoft.VisualBasic;
using System.Windows.Forms.Design;
using System.Windows.Forms;

namespace Lecture44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {

            int num = 0;
            do
            {
                num = 0;
                string message = Interaction.InputBox("Please enter number");
                for (int i = 0; i < message.ToString().Length; i++)
                {
                    num += (int)Char.GetNumericValue(message[i]);
                }
            } while (num > 10);
        }

        private void BtnProblem3_Click(object sender, EventArgs e)
        {
            string message = "";
            do
            {
                message = Interaction.InputBox("Please enter 10 digit barcode");
            } while (message.Length != 12);
            int oddTotal = 0;
            int evenTotal = 0;
            for (int i = 0; i < message.ToString().Length; i = i + 2)
            {
                oddTotal += (int)Char.GetNumericValue(message[i]);
            }
            for (int i = 1; i < message.ToString().Length; i = i + 2)
            {
                evenTotal += (int)Char.GetNumericValue(message[i]);
            }
            int total = 0;
            total = oddTotal * 3 + evenTotal;
            if (total % 10 == 0)
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private void BtnProblem4_Click(object sender, EventArgs e)
        {
            string creditCardNumber = "";
            do
            {
                creditCardNumber = Interaction.InputBox("Please enter 10 digit credit card number.");
            } while (creditCardNumber.Length != 10);
            int S1 = 0;
            int oddTotal = 0;
            int S2 = 0;
            for (int i = 1; i < creditCardNumber.ToString().Length - 2; i = i + 2)
            {
                S1 += (int)Char.GetNumericValue(creditCardNumber[i]);
            }
            for (int i = 0; i < creditCardNumber.ToString().Length; i = i + 2)
            {
                oddTotal += creditCardNumber[i];
            }
            oddTotal = (int)char.GetNumericValue((char)oddTotal) * 2;

            oddTotal = oddTotal * 2;
            for(int j = 0; j < oddTotal.ToString().Length; j++)
            {
                S2 += (int)char.GetNumericValue((char)(oddTotal));
            }
            int otu = S1 + S2;
            int lastDigit = 10 - creditCardNumber[9];

            if(otu == lastDigit) {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}