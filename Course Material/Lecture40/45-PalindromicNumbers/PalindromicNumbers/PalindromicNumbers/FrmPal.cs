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

namespace PalindromicNumbers
{
    public partial class FrmPal : Form
    {
        public FrmPal()
        {
            InitializeComponent();
        }

        int [] digits = new int[1001]; //array to store super long sums
        int counter;

        private void BtnPal_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\pal.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            string number;
            string numberreverse;
            string total;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    counter = 0;
                    number = line;

                    TxtDisplay.Text += number + " ";

                    while (true)
                    {
                        numberreverse = reverse(number);
                        total = strTotal(number, numberreverse);

                        counter++;

                       

                        if (isPalidrome(total))
                        {
                            TxtDisplay.Text += "Palidrome found after "+ counter  + " iterations " + " new palidrome is " + total +   Environment.NewLine;
                            break;
                        }
                        else if (counter==100)
                        {
                            TxtDisplay.Text += "NOT POSSIBLE " + total.ToString() + Environment.NewLine;
                            break;
                        }

                        number = total;
                    }

                                      
                }
            }
        }

        private string reverse(string n)
        {
            string reversenumber = "";

            for (int i=n.Length -1;i>=0; i--)
            {
                reversenumber += n.Substring(i, 1);
            }

            return reversenumber;
        }

        private bool isPalidrome(string n)
        {
            string r = reverse(n);

            if (n==r)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        //SUPER LONG SUMS!!!!!
        //You cannot deal with very large numbers AS NUMBERS
        //You must deal with them as STRINGS
        //The strategy below takes each digit of the super long numbers (really strings)
        //and adds there values for each digit position
        //eg
        //Lets say we want to add 9876 + 5375 ---> "9876" + "5375"
        //      9  8  7  6
        //      5  3  7  5
        //      ----------
        //      14 11 14 11
        //
        // step by step normalization
        //
        //      14 11 15 1
        //      14 12 5  1
        //      15 2  5  1
        //
        //      result = 15251

        private string strTotal(string n, string r)
        {
            string totalString = "";
            int len; //the length of the numbers

            for (int i=0;i<=100;i++)
            {
                digits[i] = 0;
            }

            len = n.Length - 1; //don't need to take both lengths
                                //because they are just reverses of themselves

            //take each string digit and add them together
            //store the small sum into the array digits[]

            for (int i=0;i<=len;i++)
            {
                digits[i] = int.Parse(n.Substring(i, 1)) + int.Parse(r.Substring(i, 1));
            }

            //very important variables - these will be used to add up the array contents
            //and simulate manual addition
            int carry = 0;
            int sum = 0;

            for (int i=len;i>=0;i--)    //start from the far right... the one's digit
            {                           //and work yourway to the far left digit
                if (i==0)               //when i is zero take the full result
                {                       //no need to work out extra carry
                    digits[i] += carry;
                }
                else
                {
                    sum = digits[i] + carry;
                    carry = sum / 10;       //for instance if we have 12 this means carry 1
                    digits[i] = sum % 10;   //for instance if we have 12 this means 2 is the 
                }                           //remaining digit
            }

            //here we now form the new number
            for (int i=0;i<=len;i++)
            {
                totalString += digits[i].ToString();
            }

            return totalString;
        }
    }
}
