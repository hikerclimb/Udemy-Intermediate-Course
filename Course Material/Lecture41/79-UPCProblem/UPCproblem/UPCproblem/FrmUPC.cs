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

namespace UPCproblem
{
    public partial class FrmUPC : Form
    {
        public FrmUPC()
        {
            InitializeComponent();
        }

        private void BtnUPC_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\upc.txt";

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
                   TxtDisplay.Text += line +  " -> " + CheckDigit(line) + Environment.NewLine;
                }
            }
        }

        private string CheckDigit(string code)
        {
            string newcode = "";
            int sum1 = 0;
            int sum2 = 0;
            int total = 0;            

            //upc code 070617006092
            
            //add up even numbered digits ... in string position terms 1,3,5,7,9,11
            for (int i=1;i<=11;i+=2)
            {
                sum1 += int.Parse(code.Substring(i, 1));
            }

            //add up the odd numbered digits ... in string position terms 0,2,4,6,8,10 
            for (int i=0;i<=10;i+=2)
            {
                sum2+=int.Parse(code.Substring(i, 1));
            }

            sum2 = sum2 * 3;

            total = sum1 + sum2;

            //Another way to do the calculations from above
            int NewWayTotal = 0;
            for (int i=0;i<code.Length;i++)
            {
                NewWayTotal+= int.Parse(code.Substring(i, 1))* (i%2==0 ?3:1);
                //The conditional operator ? also known as the ternary conditional operator,
                //evaluates a Boolean expression and returns the result of one of the two expressions,
                //depending on whether the Boolean expression evaluates to true or false
            }

            //original code had valid check digit
            if (total%10==0)
            {
                newcode = code;  
            }
            else
            {
                newcode = LastDigit(code, total);
            }


            return newcode;
        }

        private string LastDigit(string originalcode, int num)
        {
            //We passed down the original code and the sum of the digits
            //from which we will create the fully formed upc with the correct check digit

            string UPCwithCheckdigit = "";            
            int check=0;
            
            //Here we determine the total less the last digit since this digit did not give us a total evenly divisible by 10
            string numString = num.ToString();            
            int totalminuslast = num - int.Parse(originalcode.Substring(originalcode.Length - 1));

            //There are several techniques to now determine how we can get this "totalminuslast" to the next multiple of 10
            //For instance ... if the totalminuslast is 68 we need 2 more to get to 70
            //So our check digit would be 2
            
            //Technique One
            while (totalminuslast >10)
            {
                totalminuslast -= 10;
            }
            check = 10 - totalminuslast;

            //Technique Two
            int remainder = totalminuslast % 10;
            check = 10 - remainder;

            UPCwithCheckdigit   = originalcode.Substring(0, originalcode.Length-1) + check.ToString();

            return UPCwithCheckdigit;   
            
        }
    }
}
