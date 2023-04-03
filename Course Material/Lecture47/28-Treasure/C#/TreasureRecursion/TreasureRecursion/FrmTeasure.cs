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


namespace TreasureRecursion
{
    public partial class FrmTeasure : Form
    {
        public FrmTeasure()
        {
            InitializeComponent();
        }

        int r;
        int c;
        int startrow, startcolumn, TreasureRow, TreasureColumn;

        string[,] grid = new string[100, 100];
        string[] lines;

        string Wall = "X";       
        string Treasure = "T";
        string Visited = ".";
        string Empty = " ";
       

        private void BtnTreasure_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\treasure.txt";

            StreamReader read = new StreamReader(f);

            string WholeLine;

            TxtDisplay.Clear();

            //store the grid in a 2d array
            int n = int.Parse(read.ReadLine());

            for (int t = 1; t <= n; t++)
            {
                                

                WholeLine = read.ReadLine();

                lines = WholeLine.Split(' ');

                r = int.Parse(lines[0]);
                c = int.Parse(lines[1]);
                               
                for (int x = 1; x <= r; x++)
                {
                    string oneLine = read.ReadLine();

                    for (int y = 1; y <= c; y++)
                    {
                        grid[x, y] = oneLine.Substring(y - 1, 1);

                        if (grid[x, y] == "S")
                        {
                            startrow = x;
                            startcolumn = y;
                        }

                        if (grid[x, y] == "T")
                        {
                            TreasureRow = x;
                            TreasureColumn = y;
                        }
                    }

                   
                }               

                Display(grid, r, c, "Original Grid");
                TxtDisplay.Text += "Starting position is row: " + startrow.ToString() + " column :" + startcolumn.ToString() + Environment.NewLine;
                TxtDisplay.Text += "Treasure position is row: " + TreasureRow.ToString() + " column :" + TreasureColumn.ToString() + Environment.NewLine;
                TxtDisplay.Text += Environment.NewLine;

                //start the search for the treasure
                if (SearchForTreasure())
                {
                    TxtDisplay.Text += "Treasure found and reachable at row " + TreasureRow + " column " + TreasureColumn + Environment.NewLine;
                    
                }
                else
                {
                    TxtDisplay.Text += "Treasure not reached" + Environment.NewLine;
                }

                TxtDisplay.Text += Environment.NewLine;
            }

            read.Close();

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

        //Call the Recursive Search
        private bool SearchForTreasure()
        {

            return Search(startrow, startcolumn);
        } 

        private bool IsBlocked(int row,int column)
        {
            return grid[row, column] == Wall || grid[row, column] == Visited;

        }

        //The actual Recursive Search
        private bool Search(int row,int col)
        {
            if (IsBlocked(row, col))
                return false;

           
            // check if this cell contains the treasure
            if (grid[row,col] == Treasure)
            {
                TreasureRow = row;
                TreasureColumn = col;
                return true;
            }

            // drop a bread crumb at the current spot ... to track that you have been there
            if (grid[row,col] == Empty)
                grid[row,col] = Visited;

            // examine the square to the left
            if (Search(row, col - 1))
                return true;

            // examine the square above this one
            if (Search(row - 1, col))
                return true;

            // examine the square to the right
            if (Search(row, col + 1))
                return true;

            // examine the square below this one
            if (Search(row - 1, col))
                return true;

            return false;
        }
    }
}
