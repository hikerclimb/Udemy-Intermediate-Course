using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NumberSorter
{
    public partial class FrmNumberSorter : Form
    {
        public FrmNumberSorter()
        {
            InitializeComponent();
        }

        string[] lines;

        string[] snumber = new string[100];
        double[] number = new double[100];
        int[] p = new int[100];

        private void BtnSorter_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\numbers.txt";
            StreamReader read = new StreamReader(f);

            string WholeLine;
            int counter = 0;
                       
            TxtDisplay.Clear();
            
            bool finished = false;
           
            while (!finished)
            {
                //read entire game call
                WholeLine = read.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                    counter++;
                    
                    //pull apart each call
                    lines = WholeLine.Split(',');

                    //number of calls per game may be different 
                    int u = lines.Length;

                    for (int y = 0; y < u; y++)
                    {                        
                        snumber[y] = lines[y];
                        
                        int flag = 0;
                        int p=0;
                        double first=0;
                        double second=0;

                        for (int j=0;j<snumber[y].Length;j++)
                        {
                            if (snumber[y].Substring(j,1)=="/")
                            {
                                flag=1;
                                p = j;
                            }
                        }
                        if (flag == 0)
                        {
                            number[y] = double.Parse(snumber[y]);
                        }
                        else
                        {
                            first=double.Parse(snumber[y].Substring(0,p));
                            second=double.Parse(snumber[y].Substring(p+1));
                            number[y]=(double)first/second;
                        }


                     
                    }

                    TxtDisplay.Text += "List " + counter.ToString() + " Sorted" + Environment.NewLine;

                    NumberSort(number,u-1);

                    TxtDisplay.Text += Environment.NewLine;

                }
            }


            read.Close();
        }

        private void NumberSort(double []n,int upper)
        {
            int temp;

            for (int i = 0; i <= upper; i++)
                p[i] = i;

            for (int j = 0; j <= upper - 1; j++)
            {
                for (int k = j + 1; k <= upper; k++)
                {
                    if (n[p[j]] > n[p[k]])
                    {
                        temp = p[j];
                        p[j] = p[k];
                        p[k] = temp;
                    }
                }
            }

            for (int j = 0; j <= upper; j++)
            {
                TxtDisplay.Text+= snumber[p[j]] + Environment.NewLine;

            }


        }
    }
}
