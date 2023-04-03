using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FloodFill
{
    public partial class FrmFloodFill : Form
    {
        public FrmFloodFill()
        {
            InitializeComponent();
        }

        //Fill an irregular shape
        //*****************************************************************************        
        //Prepare a text file for simulating flood filling a given closed shape. 
        //Then write a program that uses recursion to fill the inside of such a shape
        //with 'T', given any interior point. Print the file before and after the fill.
        //*****************************************************************************
        //
        //40 
        //15
        //.....TTTTTTT............................
        //....T.......TTTTTTTTTTTT................
        //...T....................TTTT............
        //....T......................T............
        //..TT.....................TT.............
        //.T.......................T..............
        //..T.......................TTT...........
        //...TT........................T..........
        //.....T........................T.........
        //.....T.....TT.................T.........
        //.....T...TT..TT..............T..........
        //....T....T.....T..........TTT...........
        //...T......T....TTT....TTTT..............
        //....T......T.....TTTTT..................
        //.....TTTTTT.............................
        //

        int rows;
        int cols;
        
        string[,] grid = new string[100, 100];


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            DataFile(grid, ref rows, ref cols);

            TxtDisplay.Clear();
            Display(grid, rows, cols,"Original Grid");

            FloodFill(10,10);
            
            Display(grid, rows, cols,"Flood Filled Grid");
        }

        private void DataFile(string[,] m, ref int r, ref int c)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\fillfield1.txt";

            StreamReader read = new StreamReader(f);

            c = Convert.ToInt32(read.ReadLine());
            r = Convert.ToInt32(read.ReadLine());

            for (int x = 1; x <= r; x++)
            {
                string oneLine = read.ReadLine();

                for (int y = 1; y <= c; y++)
                {
                    m[x, y] = oneLine.Substring(y - 1, 1);
                }
            }

            read.Close();
        }

        private void Display(string[,] m, int rows, int cols,string text)
        {
            
            TxtDisplay.Text += text + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;


            for (int r = 1; r <= rows; r++)
            {

                for (int c = 1; c <= cols; c++)
                {
                    TxtDisplay.Text += Convert.ToString(m[r, c]);
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }

        private void FloodFill(int r, int c)
        {

            if (validLoc(r, c))
            {
                grid[r,c] = "#";

                FloodFill(r + 1, c);
                FloodFill(r - 1, c);
                FloodFill(r, c + 1);
                FloodFill(r, c - 1);
            }
        }

        private bool validLoc(int r, int c)
        {
            bool valid = false;

            if (r >= 1 && r <= rows && c >= 1 && c <= cols)
            {
                if (grid[r, c] == ".")
                {
                    valid = true;
                }
            }
            return valid;
        }
    }
}