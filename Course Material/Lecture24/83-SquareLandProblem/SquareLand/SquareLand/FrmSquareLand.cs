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

namespace SquareLand
{
    public partial class FrmSquareLand : Form
    {
        public FrmSquareLand()
        {
            InitializeComponent();
        }

        int[,] grid = new int[11, 11];
        string[] lines;

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "SquareLand Results" + Environment.NewLine + Environment.NewLine;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\square.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            int n = 0; // square root of entire lot size
            int s = 0; //square root of size of lot to purchase from entire lot
            bool finished = false;

            while (!finished)
            {
                WholeLine = r.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                    n = (int) Math.Sqrt(int.Parse(WholeLine));
                    s = (int) Math.Sqrt(int.Parse(r.ReadLine()));

                    //store entire lot in 2d grid
                    for (int x=1;x<=n;x++)
                    {
                        WholeLine = r.ReadLine();
                        lines = WholeLine.Split(' ');

                        for (int y=1;y<=n;y++)
                        {
                            grid[x, y] = int.Parse(lines[y - 1]);
                        }
                    }

                    Display(grid, n, n, "Original Grid");
                    TxtDisplay.Text += "Maximum Yield for lot size " + s.ToString() + "x" + s.ToString() + " is " + MaxYield(grid,n,s) + Environment.NewLine;
                    TxtDisplay.Text += "--------------------------------------------------" + Environment.NewLine;
                }

                ClearGrid();
            }

            r.Close();
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

        private void ClearGrid()
        {
            for(int r=1;r<=10;r++)
            {
                for (int c=1;c<=10;c++)
                {
                    grid[r, c] = 0;
                }
            }
        }

        private int MaxYield (int[,] m , int n,int s)
        {
            int maxsum = 0;

            //work through all the possible combinations of sxs lots
            //and determine the largest sum
            for (int x=1;x + s-1 <=n;x++)
            {
                for (int y=1;y+s-1<=n;y++)
                {
                    maxsum = Math.Max(GridSum(m, x, y, s, s), maxsum);
                }
            }

            return maxsum;
        }

        private int GridSum(int [,] g,int x,int y, int row, int col)
        {
            int sum = 0;

            for (int i=1;i<=row;i++)
            {
                for (int j=1;j<=col;j++)
                {
                    sum += g[x + i-1, y+j-1];
                }
            }

            return sum;
        }
    }
}
