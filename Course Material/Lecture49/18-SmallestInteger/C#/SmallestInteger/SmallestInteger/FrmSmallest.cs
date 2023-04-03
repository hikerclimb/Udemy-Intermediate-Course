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

namespace SmallestInteger
{
    public partial class FrmSmallest : Form
    {
        public FrmSmallest()
        {
            InitializeComponent();
        }

        int[] numbers = new int[100];
        int[] newnumbers = new int[100];
        int[] digits = new int[100];
        int n;

        private void BtnSmallest_Click(object sender, EventArgs e)
        {
            int c = 0;

            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\smallest.txt";

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
                    c++;
                    numbers[c] = int.Parse(line);
                }
            }

            r.Close();

            n = c;

            //original list
            for (int i=1;i<=n;i++)
            {
                TxtDisplay.Text += numbers[i] + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;


            smallest(numbers, n);
        }

        private void smallest(int []num,int u)
        {
            string stringn, newn;

            //pull apart each digit and store in array for future sorting
            for (int i=1;i<=u;i++)
            {
                stringn = num[i].ToString();

                for (int k=0;k<stringn.Length;k++)
                {
                    digits[k] = int.Parse(stringn.Substring(k, 1));
                }

                bubblesort(digits, 0, stringn.Length - 1);

                newn = "";

                //after digit array is sorted ... reform sorted digits into new number

                for (int k=0;k<stringn.Length;k++)
                {
                    newn += digits[k].ToString();
                }

                newnumbers[i] = int.Parse(newn);
            }

            //sort new list of numbers

            bubblesort(newnumbers, 1, u);

            for(int i=1;i<=u;i++)
            {
                TxtDisplay.Text += newnumbers[i].ToString() + Environment.NewLine;
            }


        }

        private void bubblesort(int []array,int lower,int upper)
        {
            string flag = "";
            int temp;

            while(true)
            {
                flag = "yes";
                for (int k=lower;k<=upper-1;k++)
                {
                    if (array[k]>array[k+1])
                    {
                        temp = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = temp;
                        flag = "no";
                    }
                }

                if (flag == "yes")
                    break;
            }


        }
    }
}
