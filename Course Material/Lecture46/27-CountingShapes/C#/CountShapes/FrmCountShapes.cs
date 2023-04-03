using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CountShapes
{
    public partial class FrmCountShapes : Form
    {
        public FrmCountShapes()
        {
            InitializeComponent();
        }

        int rShape = 0;
        int cShape = 0;
        int rectnum = 0;
        int shapeCtr = 0;
        StreamReader read;

        string[,] grid = new string[100, 100];

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\shape.txt";

            read = new StreamReader(f);

            string line;

            TxtShapes.Text = "Original Grid" + Environment.NewLine;

            //the while statement below saves us having to use a boolean
            //Recall
            //bool finished = false;

            //while (!finished)
            //{
            //    line = r.ReadLine();
            //
            //    if (line == null)
            //    {
            //        finished = true;
            //    }
            //    else
            //    {
            //        
            //    }
            //}

            while ((line = read.ReadLine()) != null)
            {

                rectnum++;

                cShape = Convert.ToInt32(line);
                rShape = Convert.ToInt32(read.ReadLine());

                LoadShape(grid, rShape, cShape);
                Display(grid, rShape, cShape);

                TxtShapes.Refresh();

                shapeCtr = 0;

                //call the main routine which then makes a call to a recursive method
                WalkGrid();

                TxtShapes.Text += "In Rectangle # :" + rectnum.ToString() + " there are " + shapeCtr.ToString() + " shapes" + Environment.NewLine; ;
            }

            read.Close();

            MessageBox.Show("Recursion Complete");
        }

        private void LoadShape(string[,] m, int rows, int cols)
        {
            

            for (int x = 1; x <= rows; x++)
            {
                string oneLine = read.ReadLine();

                for (int y = 1; y <= cols; y++)
                {
                    m[x, y] = oneLine.Substring(y - 1, 1);
                }
            }
            
        }

        private void Display(string[,] m, int rows, int cols)
        {
            TxtShapes.Text += Environment.NewLine;
            
            for (int x = 1; x <= rows; x++)
            {

                for (int y = 1; y <= cols; y++)
                {
                    TxtShapes.Text += Convert.ToString(m[x, y]);
                }
                TxtShapes.Text += Environment.NewLine;
            }

            TxtShapes.Text += Environment.NewLine;
        }

        private void WalkGrid()
        {
            for (int r = 1; r <= rShape; r++)
            {
                for (int c = 1; c <= cShape; c++)
                {
                    if (grid[r, c] == "X")
                    {
                        shapeCtr++;
                        testLoc(r, c);  //the recursive method
                    }
                }
            }
        }

        private void testLoc(int r,int c)
        {
            if (validLoc(r,c))
            {
                grid[r, c] = ".";   //mark as already travelled 
                                    //otherwise you will have an endless loop
                testLoc(r+1,c);
                testLoc(r-1,c);
                testLoc(r,c+1);
                testLoc(r,c-1);
            }
        }


        private bool validLoc(int r, int c)
        {
            bool valid = false;

            if (r >= 1 && r <= rShape && c >= 1 && c <= cShape)
            {
                if (grid[r, c] == "X")
                {
                    valid = true;
                }
            }
            return valid;
        }

        
    }
}