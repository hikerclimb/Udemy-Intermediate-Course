using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ISBNApplication
{
    public partial class FrmISBN : Form
    {
        public FrmISBN()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            int [] c = new int[14];
            string ISBN,NewISBN;

            int multiplier,total,final;

            do
            {
                ISBN = Microsoft.VisualBasic.Interaction.InputBox("enter ISBN including dashes", "ISBN Validation", "", 200, 200);
            }
            while (ISBN.Length != 13);

            
            
            //Get rid of the dashes in the ISBN and form a new string

            NewISBN = "";
            
            for (int i=0;i<ISBN.Length;i++)
            {
                string character = ISBN.Substring(i,1);
                char tempchar = Convert.ToChar(character);

                //cant say character>="0" must convert it to type char first
                if ((tempchar>='0' && tempchar<='9') || character=="x")
                {
                    NewISBN+=character;
                }
            }
            
            
            //Convert each character to a number
            
            for(int i=0;i<NewISBN.Length;i++)
            {
                string character=NewISBN.Substring(i,1);

                if (character=="x")
                {
                    character="10";
                }

                c[i]=int.Parse(character);
            }
                        

            //Multiply digits 1-9 by numbers 10-2

            total = 0;
            multiplier = 10;

            for(int i=0;i<=8;i++)
            {
                total+= c[i] * multiplier;
                multiplier --;
            }

            //Add check digit to Total and check if the Final total
            //is divisible by 11
            
            final = total + c[9];
            
            if (final%11==0)
            {
                MessageBox.Show("Number is Valid");
            }
            else
            {
                MessageBox.Show("Number is Invalid");
            }
            
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int [] c = new int[14];
            string ISBN,NewISBN,CheckString;

            int multiplier,total,final,CheckDigit;
            
            do
            {
                ISBN = Microsoft.VisualBasic.Interaction.InputBox("enter Partial ISBN including last dash", "ISBN Validation", "", 200, 200);
            }
            while (ISBN.Length != 12);
            
                        
            //Get rid of the dashes in the ISBN and form a new string
            
            NewISBN = "";
            
            for (int i=0;i<ISBN.Length;i++)
            {
                string character = ISBN.Substring(i,1);
                char tempchar = Convert.ToChar(character);

                //cant say character>="0" must convert it to type char first
                if ((tempchar>='0' && tempchar<='9') || character=="x")
                {
                    NewISBN+=character;
                }
            }
                        
            
            //Convert each character to a number
            
            for(int i=0;i<NewISBN.Length;i++)
            {
                string character=NewISBN.Substring(i,1);

                if (character=="x")
                {
                    character="10";
                }

                c[i]=int.Parse(character);
            }
            
            
            //Multiply digits 1-9 by numbers 10-2

            total = 0;
            multiplier = 10;

            for(int i=0;i<=8;i++)
            {
                total+= c[i] * multiplier;
                multiplier --;
            }

            //Determine the required check digit (11-remainder of Total/11)
            
            int Remainder= total%11;
            CheckDigit = 11 - Remainder;

            if (CheckDigit==10)
            {
                CheckString="x";
            }
            else if (CheckDigit==11)
            {
                CheckString="0";
            }
            else
            {
                CheckString=Convert.ToString(CheckDigit);
            }
                                    
            MessageBox.Show("For the partial ISBN " + ISBN + "\n" + "The check digit should be " + CheckString);

             
        }
    }
}