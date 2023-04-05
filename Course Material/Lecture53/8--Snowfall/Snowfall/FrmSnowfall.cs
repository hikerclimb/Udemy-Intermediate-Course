using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Snowfall
{
    public partial class FrmSnowfall : Form
    {
        public FrmSnowfall()
        {
            InitializeComponent();
        }

        string [] years  = new string [10];
        string [] sites  = new string [10];
        int [,]snow  = new int [6,7];
        int [] siteTotal  = new int [6];
        double [] siteAverage = new double [6];
        int [] pointers = new int [6];

        private void DataFile()
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\snowfall.txt";

            StreamReader read = new StreamReader(f);

            

            for (int y = 1; y <= 6; y++)
            {
                years[y] = read.ReadLine();
            }

            for (int n = 1; n <= 5; n++)
            {
                sites[n] = read.ReadLine();
            }

            
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    snow[r, c] = Convert.ToInt32(read.ReadLine());
                }
            }

            read.Close();
        }

        private void BtnPerform_Click(object sender, EventArgs e)
        {
            DataFile();
            CalculateTotals();
            SortAverages();
            DisplayResults();
        }

        private void CalculateTotals()
        {
            for (int i = 1; i <= 5; i++)
            {
                siteTotal[i] = 0;
            }

            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 6; c++)
                {
                    siteTotal[r] = siteTotal[r] + snow[r,c];
                }
            }

            for (int r = 1; r <= 5; r++)
            {
                siteAverage[r] = siteTotal[r] / 6.0;
            }

        }

        private void SortAverages()
        {

            int temp;

            for (int i = 1; i <= 5; i++)
                pointers[i] = i;

            for (int j = 1; j <= 5 - 1; j++)
            {
                for (int k = j + 1; k <= 5; k++)
                {
                    if (siteAverage[pointers[j]] < siteAverage[pointers[k]])
                    {
                        temp = pointers[j];
                        pointers[j] = pointers[k];
                        pointers[k] = temp;
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void DisplayResults()
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Snowfall Analysis" + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;

            TxtDisplay.Text+= "Site" + "\t" ;

            for (int c = 1; c <= 6; c++)
            {
                TxtDisplay.Text += years[c] +  "\t" ;
            }

            TxtDisplay.Text += Environment.NewLine;

            for (int r = 1; r <= 5; r++)
            {
                TxtDisplay.Text += sites[r] + "\t";
                for (int c = 1; c <= 6; c++)
                {
                    TxtDisplay.Text += Convert.ToString(snow[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;

            TxtDisplay.Text +="Site" + "\t" + "Average SnowFall" + Environment.NewLine;

            for (int i = 1; i <= 5; i++)
            {
                TxtDisplay.Text += sites[pointers[i]] + "\t" + siteAverage[pointers[i]].ToString("n2")+ Environment.NewLine;
            }
        }



     }
 }