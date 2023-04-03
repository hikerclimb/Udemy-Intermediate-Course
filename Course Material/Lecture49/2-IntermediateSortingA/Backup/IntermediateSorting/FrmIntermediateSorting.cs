using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IntermediateSorting
{
    public partial class FrmIntermediateSorting : Form
    {
        public FrmIntermediateSorting()
        {
            InitializeComponent();
        }

        int c ;
        int n ;
        string [] names = new string [2000];
        
        private void FrmIntermediateSorting_Load(object sender, EventArgs e)
        {
            DataFile();
            DisplayOriginalList();
        }

        private void DataFile()
        {

            c = 0;
            n = 0;
            
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\names.txt";

            StreamReader r = new StreamReader(f);

            string line;

            while ((line = r.ReadLine()) != null)
            {
                c++;
                names[c] = line;
            }                        
            r.Close();
            n = c;
        }

        private void DisplayOriginalList()
        {
            for (int i = 1; i <= n; i++)
            {
                LstOriginal.Items.Add(names[i]);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBubble_Click(object sender, EventArgs e)
        {
            int start, elapsed;

            //re-load unsorted list
            DataFile();
            
            LstSorted.Items.Clear();

            start = Environment.TickCount;              
            BubbleSort();        
            elapsed = Environment.TickCount - start;

            TxtTime.Text = elapsed.ToString();

            DisplaySortedList();
        }

        private void DisplaySortedList()
        {
            for (int i = 1; i <= n; i++)
            {
                LstSorted.Items.Add(names[i]);
            }
        }

        private void BubbleSort()
        {
            string flag;
            
            do
            {
                flag = "yes";
                for (int k = 1; k <= n - 1; k++)
                {
                    if (names[k].CompareTo(names[k + 1])> 0)
                    {
                        Swap(names, k, k + 1);
                        flag = "no";
                    }
                }
            }
            while (flag != "yes");
        }

        private void Swap(string[] list, int a, int b)
        {
            string temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        private void BtnModifiedBubble_Click(object sender, EventArgs e)
        {
            int start, elapsed;
            
            //re-load unsorted list
            DataFile();

            LstSorted.Items.Clear();

            start = Environment.TickCount;
            ModifiedBubbleSort();
            elapsed = Environment.TickCount - start;

            TxtTime.Text = elapsed.ToString();

            DisplaySortedList();
        }

        private void BtnExchange_Click(object sender, EventArgs e)
        {
            int start, elapsed;

            //re-load unsorted list
            DataFile();
            
            LstSorted.Items.Clear();

            start = Environment.TickCount;
            ExchangeSort();
            elapsed = Environment.TickCount - start;

            TxtTime.Text = elapsed.ToString();

            DisplaySortedList();
        }

        private void BtnShell_Click(object sender, EventArgs e)
        {
            int start, elapsed;

            //re-load unsorted list
            DataFile();

            LstSorted.Items.Clear();

            start = Environment.TickCount;
            ShellSort();
            elapsed = Environment.TickCount - start;

            TxtTime.Text = elapsed.ToString();

            DisplaySortedList();
        }

        private void ModifiedBubbleSort()
        {
            int h = n;
            int u;
            

            do
            {

                u = h - 1;
                h = 1;

                for (int k = 1; k <= u; k++)
                {
                    // Swap pair (k, k + 1) if out of order.
                    if (names[k].CompareTo(names[k + 1]) > 0)
                    {
                        Swap(names, k, k + 1);
                        h = k;
                    }

                }

            }
            while (h > 1);


        }

        private void ExchangeSort()
        {
            for (int j = 1; j <= n - 1; j++)
            {
                for (int k = j + 1; k <= n; k++)
                {
                    if (names[j].CompareTo(names[k]) > 0)
                    {
                        Swap(names, j, k);
                    }

                }
            }   


        }

        private void ShellSort()
        {
            int gap = n;
            int maximum, iplusg, ex;
                        
            do
            {
                gap = gap / 2;
                maximum = n - gap;

                do
                {
                    ex = 0;

                    for (int i = 1; i <= maximum; i++)
                    {
                        iplusg = i + gap;

                        if (names[i].CompareTo(names[iplusg]) > 0)
                        {
                            Swap(names, i, iplusg);
                            ex = ex + 1;
                        }
                    }
                }
                while (ex != 0);

            }
            while (gap >= 1);


        }
    }
}