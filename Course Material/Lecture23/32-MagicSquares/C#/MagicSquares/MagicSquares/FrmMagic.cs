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

namespace MagicSquares
{
    public partial class FrmMagic : Form
    {
        public FrmMagic()
        {
            InitializeComponent();
        }

        //declare 2d array for magic square
        //and lines array needed for Split command
        int[,] grid;
        string[] lines;        
        int r;

        private void BtnMagic_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\magic.txt";
            StreamReader read = new StreamReader(f);

            string WholeLine;
            bool finished = false;

            TxtDisplay.Clear();

            while (!finished)
            {
                
                WholeLine = read.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                    r = int.Parse(WholeLine);

                    //declare 2d array size
                    grid = new int[r, r];

                    for (int x = 0; x < r; x++)
                    {
                        WholeLine = read.ReadLine();

                        lines = WholeLine.Split(' ');

                        for (int y = 0; y < r; y++)
                        {
                            grid[x, y] = int.Parse(lines[y]);
                        }
                    }
                   
                    Display(grid, r, r);

                    string status = DetermineMagic(grid, r);
                    TxtDisplay.Text += status + Environment.NewLine;
                }
               
            }

            read.Close();
        }

        private string DetermineMagic(int [,]g,int rows)
        {

            string st = "MAGIC";

            //get total
            int total = 0;
            for (int i=0;i<rows;i++)
            {
                total += g[i, 0];
            }

            //process board: ROWS
            for (int r=0;r<rows;r++)
            {
                int sum = 0;
                for (int c=0;c<rows;c++)
                {
                    sum += g[r, c];
                }

                if (sum!=total)
                {
                    st = "NOT MAGIC";                    
                }
            }

            //process board:COLUMNS
            for (int c=0;c<rows;c++)
            {
                int sum = 0;
                for (int r=0;r<rows;r++)
                {
                    sum += g[r, c];
                }

                if (sum!=total)
                {
                    st = "NOT MAGIC";
                }
            }

            //process board:DIAGONALS
            int sum1 = 0;
            int sum2 = 0;

            for (int c=0;c<rows;c++)
            {
                sum1+= g[c, c];
                sum2 += g[rows - c - 1, c];
            }

            if (sum1!=total)
            {
                st = "NOT MAGIC";
            }

            if (sum2!=total)
            {
                st = "NOT MAGIC";
            }

            return st;

        }

        private void Display(int[,] m, int rows, int cols)
        {

            TxtDisplay.Text += Environment.NewLine;


            for (int r = 0; r < rows; r++)
            {

                for (int c = 0; c < cols; c++)
                {
                    TxtDisplay.Text += Convert.ToString(m[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            //TxtDisplay.Text += Environment.NewLine;

        }
    }
}
