using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SubstringExtracting
{
    public partial class FrmSubstringExtract : Form
    {
        public FrmSubstringExtract()
        {
            InitializeComponent();
        }

        private void BtnExtract_Click(object sender, EventArgs e)
        {
            string fullname;
            string firstname, lastname;
            string response;

            while (true)
            {

                while(true)
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you have anymore entries y/n? ", "Continue?", "", 200, 200);
                    if (response == "y" || response == "n")
                        break;
                }                

                if (response == "n")
                    break;
                
                fullname = Microsoft.VisualBasic.Interaction.InputBox("Enter your Fullname ", "Substring Extracting", "", 200, 200);

                int pos = fullname.IndexOf(' ');

                if (pos == -1)
                {
                    MessageBox.Show(fullname + " is not separated by a space");
                }
                else
                {
                    firstname = fullname.Substring(0, pos );
                    lastname = fullname.Substring(pos + 1);

                    MessageBox.Show(lastname + " " +firstname);
                }

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}