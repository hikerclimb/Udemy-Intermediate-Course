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

namespace Navigation
{
    public partial class FrmNav : Form
    {
        public FrmNav()
        {
            InitializeComponent();
        }

        string [,] grid = new string[5, 5];

        private void BtnNav_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\navigation.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            int row;
            int col;

            //read in the location of the planet 
            row= int.Parse(r.ReadLine());
            col= int.Parse(r.ReadLine());


            while (!finished)
            {
                //read in an attempted path to get to the planet
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    TxtDisplay.Text += line + " -> " + FindPlanet(row,col,line) +  Environment.NewLine;                    
                }
            }
        }

        private string FindPlanet(int r, int c,string path)
        {
            string status = "";

            string dir = "";
            
            //start attempted path from top left corner of the grid
            int currentR=1;
            int currentC = 1;

            //Reset the grid for each new attempted path
            for (int i=1;i<=4;i++)
            {
                for (int j=1;j<=4; j++)
                {
                    grid[i, j] = "-";
                }
            }

            //mark our destination with an asterisks
            grid[r, c] = "*";

            for (int i=0;i<path.Length;i++)
            {
                dir = path.Substring(i, 1);

                if (dir=="u")
                {
                    currentR--;
                }
                else if (dir=="d")
                {
                    currentR++;
                }
                else if ( dir=="l")
                {
                    currentC--;
                }
                else if (dir=="r")
                {
                    currentC++;
                }
            }

            if (grid[currentR,currentC] =="*")
            {
                status = "You got to the planet";
            }
            else
            {
                status = "You didn't get to the planet";
            }

            return status;
        }
    }
}
