using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MoneyPrize
{
    public partial class FrmMoneyPrize : Form
    {
        public FrmMoneyPrize()
        {
            InitializeComponent();
        }

        int[,] grid = new int[10, 10];
        int[] money = new int[10000];
        string[] path = new string[10000];

        string[] lines;        
        
        int count;

        private void BtnMoneyPrize_Click(object sender, EventArgs e)
        {
            readGrid(grid, 8, 8);
            TxtDisplay.Clear();
            Display(grid, 8, 8, "Original Grid");

           
            count = 0;
            bestPath(8, 1, grid[8, 1],""+ grid[8,1]);

            sort(money, path,count);
            top5(money,path);
        }

        private void readGrid(int[,] m, int r, int c)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\money.txt";

            StreamReader read = new StreamReader(f);

            string WholeLine;

            for (int x = 1; x <= r; x++)
            {
                WholeLine = read.ReadLine();

                lines = WholeLine.Split(' ');

                //Alternate Solution
                //where the number of data per row varies
                //***************************************
                //int u = lines.Length;
                //for(int y=1;y<=u;y++)

                for (int y = 1; y <= c; y++)
                {
                    m[x, y] = int.Parse(lines[y - 1]);
                }
            }

            read.Close();
        }

        private void Display(int[,] m, int rows, int cols, string text)
        {

            TxtDisplay.Text += text + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;


            for (int r = 1; r <= rows; r++)
            {

                for (int c = 1; c <= cols; c++)
                {
                    TxtDisplay.Text += Convert.ToString(m[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }

        private void bestPath(int x, int y, int cost,string p)
        {

            if (x >= 2)
            {
                bestPath(x - 1, y, cost + grid[x - 1, y], p + " " + grid[x-1,y]);
            }
            if (y < 8)
            {
                bestPath(x, y + 1, cost + grid[x, y + 1],p + " " + grid[x,y+1]);
            }
            if (x == 1 && y == 8)
            {
                count++;
                money[count] = cost;
                path[count] = p;
            }


        }

        private void sort(int[] array, string [] pa,int upper)
        {

            //perform a bubble sort on the array of prize money
            string flag;

            do
            {
                flag = "yes";
                for (int k = 1; k <= upper - 1; k++)
                {
                    
                    if (array[k] < array[k+1])
                    {
                        //swap prize money and path

                        int temp = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = temp;

                        string tempp = pa[k];
                        pa[k] = pa[k + 1];
                        pa[k + 1] = tempp;
                        flag = "no";
                    }
                }
            }
            while (flag != "yes");
        }

        private void top5(int[] array, string [] pa)
        {
            TxtDisplay.Text += "Top 5 Results" + Environment.NewLine+ Environment.NewLine;
            for (int i = 1; i <= 5; i++)
            {
                TxtDisplay.Text += array[i] + "->" + pa[i] + Environment.NewLine;
            }
        }


    }
}