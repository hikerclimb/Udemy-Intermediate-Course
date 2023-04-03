using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Navigate
{
    public partial class FrmNavigate : Form
    {
        public FrmNavigate()
        {
            InitializeComponent();
        }

        //Navigating a maze

        //8 8
        //BBXBBBXB
        //XBXBXBXB
        //XBXBXBXB
        //XBBBXBXB
        //BBXXXBBB
        //BXXBBBXX
        //BXXBXXXX
        //BXXBBBBB

        //..X...XB
        //X.X.X.XB
        //X.X.X.XB
        //X...X.XB
        //--XXX.BB
        //-XX...XX
        //-XX.XXXX
        //-XX.....
        //end of maze reached

        int rows;
        int cols;

        string[,] grid = new string[100, 100];


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNavigate_Click(object sender, EventArgs e)
        {
            DataFile(grid, ref rows, ref cols);

            TxtDisplay.Clear();
            Display(grid, rows, cols, "Original Grid");

            if (FindPath(1, 1))
            {
                TxtDisplay.Text += "End of Maze Reached !!" + Environment.NewLine;
                Display(grid, rows, cols, "Here is the Path");
            }
            else
            {
                TxtDisplay.Text += "There is no possible path";
            }

        }

        private void DataFile(string[,] m, ref int r, ref int c)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\maze.txt";

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

        private bool validLoc(int r, int c)
        {
            bool valid = false;

            if (r >= 1 && r <= rows && c >= 1 && c <= cols)
            {
                if (grid[r, c] == "B")
                {
                    valid = true;
                }
            }
            return valid;
        }

        private void Display(string[,] m, int rows, int cols, string text)
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

        private bool FindPath(int r, int c)
        {
            bool done = false;

            // method first checks to see if the current location is valid
            // If it is , the program marks the current position with the symbol '-'
            // This ensures that the method will not wander around the maze forever
            // if it is forced to back up.

            if (validLoc(r, c))
            {
                grid[r,c] = "-";

                if (r == rows && c == cols)
                //if (grid[r,c]=="Z")
                {
                    done = true;
                }
                else
                {
                    done = FindPath(r + 1, c);
                    if (!done)
                        done = FindPath(r, c + 1);
                    if (!done)
                        done = FindPath(r - 1, c);
                    if (!done)
                        done = FindPath(r, c - 1);
                }

                //mark this as part of a correct path
                if (done)
                    grid[r,c] = ".";

            }

            return done;
        }

        
    }
}