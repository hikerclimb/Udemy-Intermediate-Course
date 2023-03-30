using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SubstringExtractingProblems
{
    public partial class FrmSubstringExtractingProblems : Form
    {
        public FrmSubstringExtractingProblems()
        {
            InitializeComponent();
        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {
            string fulltelephone;
            string areacode, number;
            string response;

            while (true)
            {

                while (true)
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you have anymore entries y/n? ", "Continue?", "", 200, 200);
                    if (response == "y" || response == "n")
                        break;
                }

                if (response == "n")
                    break;

                fulltelephone = Microsoft.VisualBasic.Interaction.InputBox("Enter your telephone number ", "Substring Extracting", "", 200, 200);

                int pos = fulltelephone.IndexOf('-');

                if (pos == -1)
                {
                    MessageBox.Show(fulltelephone + " is not separated by a -");
                }
                else
                {
                    areacode = fulltelephone.Substring(0, pos);
                    number = fulltelephone.Substring(pos + 1);

                    MessageBox.Show("Area code: " + areacode + "\n" + "Phone Number: " + number);
                }

            }
        }

        private void BtnProblem3_Click(object sender, EventArgs e)
        {
            string fullnumber;
            string intpart, decpart;
            string response;

            while (true)
            {

                while (true)
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you have anymore entries y/n? ", "Continue?", "", 200, 200);
                    if (response == "y" || response == "n")
                        break;
                }

                if (response == "n")
                    break;

                fullnumber = Microsoft.VisualBasic.Interaction.InputBox("Enter a number with decimals ", "Substring Extracting", "", 200, 200);

                int pos = fullnumber.IndexOf('.');

                if (pos == -1)
                {
                    MessageBox.Show(fullnumber + " does not have any decimals");
                }
                else
                {
                    intpart = fullnumber.Substring(0, pos);
                    decpart = fullnumber.Substring(pos + 1);

                    MessageBox.Show(fullnumber + " has "+ decpart.Length + " decimal places" + "\n" + "The integer part is " + intpart + "\n" + "The decimal part is " + decpart);
                   
                }

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}