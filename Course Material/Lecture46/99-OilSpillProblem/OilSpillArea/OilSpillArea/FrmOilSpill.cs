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

namespace OilSpillArea
{
    public partial class FrmOilSpill : Form
    {
        public FrmOilSpill()
        {
            InitializeComponent();
        }

        int rows;
        int cols;
        
        int startrow, startcolumn;
        
        string[,] grid = new string[100, 100];
        
        //Declared outside of BtnOilSpill_Click below so it can also
        //be used in LoadShape method
        StreamReader read;

        private void BtnOilSpill_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\oil.txt";

            read = new StreamReader(f);

            string line;

            TxtDisplay.Text = "Original Grids and Number of Oil Globs" + Environment.NewLine;

            while ((line = read.ReadLine()) != null)
            {
                //read in the size of the grid
                rows = Convert.ToInt32(line);
                cols = Convert.ToInt32(read.ReadLine());

                //load the grid contents and display
                LoadShape(grid, rows, cols);
                Display(grid, rows, cols);

                TxtDisplay.Refresh();
                                                

                TxtDisplay.Text += "Start position for Oil Globs is row "+ startrow.ToString() + " column " + startcolumn.ToString()   + Environment.NewLine;
                TxtDisplay.Text += "Number of Oil Globs is " +  Globs(startrow, startcolumn)  + Environment.NewLine;
            }

            read.Close();
        }

        private void LoadShape(string[,] m, int rows, int cols)
        {


            for (int x = 1; x <= rows; x++)
            {
                string oneLine = read.ReadLine();

                for (int y = 1; y <= cols; y++)
                {
                    m[x, y] = oneLine.Substring(y - 1, 1);

                    //Look for A ... which represents where we start our Glob counting in the grid
                    if (m[x,y]=="A")
                    {
                        startrow = x;
                        startcolumn = y;
                    }
                }
            }

        }

        private void Display(string[,] m, int rows, int cols)
        {
            TxtDisplay.Text += Environment.NewLine;

            for (int x = 1; x <= rows; x++)
            {

                for (int y = 1; y <= cols; y++)
                {
                    TxtDisplay.Text += Convert.ToString(m[x, y]);
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }

        //This method uses Recursion to traverse the grid
        //backwards (c-1), forwards (c+1) , upwards(r-1) and downwards (r+1)
        private int Globs(int r, int c)
        {
            int count = 1;
            grid[r,c] = ".";
            if (grid[r,c - 1] == "#") count += Globs(r, c-1);
            if (grid[r,c + 1] == "#") count += Globs(r, c+1);
            if (grid[r - 1,c] == "#") count += Globs(r-1, c);
            if (grid[r + 1,c] == "#") count += Globs(r+1, c);
            return count;
        }
    }
}
