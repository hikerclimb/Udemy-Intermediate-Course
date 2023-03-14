using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bingo
{
    public partial class FrmBingo : Form
    {
        public FrmBingo()
        {
            InitializeComponent();
        }

        int[,] grid = new int[5, 5];
        string[] lines;


        private void BtnBingo_Click(object sender, EventArgs e)
        {
            PlayBingo(grid, 5, 5);            
        }

        private void PlayBingo(int[,] m, int r, int c)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\bingo.txt";
            StreamReader read = new StreamReader(f);

            string WholeLine;
            
            //read in bingo card
            for (int x = 0; x < r; x++)
            {
                WholeLine = read.ReadLine();

                lines = WholeLine.Split(' ');  
                
                for (int y = 0; y < c; y++)
                {
                    m[x, y] = int.Parse(lines[y]);
                }
            }

            TxtDisplay.Clear();
            Display(grid, 5, 5, "Bingo Card");

            bool finished = false;
            int game = 0;

            while (!finished)
            {
                //read entire game call
                WholeLine = read.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                    //2d array to remember CALLED numbers that ARE on BINGO card
                    bool[,] hit = new bool[5, 5];
                    //BINGO! flag
                    bool flag=false;

                    game++;
                    
                    //pull apart each call
                    lines = WholeLine.Split(' ');
                    
                    //number of calls per game may be different 
                    int u = lines.Length;

                    for (int y = 0; y < u; y++)
                    {
                        //just grab number, letter a red hering
                        //since B column numbers always in range 1..15
                        //I column numbers always in range 16..30 etc...
                        int v = int.Parse(lines[y].Substring(1));

                        
                        //go through entire BINGO card looking for called number
                        for (int row = 0; row < 5; row++)
                        {
                            for (int col = 0; col < 5; col++)
                            {
                                if (m[row, col] == v)
                                {
                                    hit[row, col] = true;
                                }
                            }
                        }              

                        //after each called number is check for its existence on card
                        //now check if BINGO exists... you never know when
                        if (win(hit))
                        {
                            TxtDisplay.Text += "Game " + game.ToString() + ":   Bingo after " + lines[y] + " was called" + Environment.NewLine;
                            flag = true;
                            break;
                        }
                    }

                    //if you went through all calls for game and no BINGO (flag still equal to false) then no BINGO
                    //now read the next game
                    if (flag == false)
                    {
                        TxtDisplay.Text += "Game " + game.ToString() + ":   No Bingo" + Environment.NewLine;
                    }

                    TxtDisplay.Text += "These were the calls for Game " + game.ToString() + Environment.NewLine;
                    for (int y = 0; y < u; y++)
                    {
                        TxtDisplay.Text += lines[y] + " ";
                    }
                    TxtDisplay.Text += Environment.NewLine+ Environment.NewLine;
                    
                }
            }           


            read.Close();
        }



        private void Display(int[,] m, int rows, int cols,string text)
        {

            TxtDisplay.Text += text + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;


            for (int r = 0; r < rows; r++)
            {

                for (int c = 0; c < cols; c++)
                {
                    TxtDisplay.Text += Convert.ToString(m[r, c]) + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;          
            
        }

        private bool win(bool[,] h)
        {
            return
            h[0, 0] && h[1, 1] && h[2, 2] && h[3, 3] && h[4, 4] ||//diagonal top left to bottom right
            h[4, 0] && h[3, 1] && h[2, 2] && h[1, 3] && h[0, 4] ||//diagonal top right to bottom left
            h[0, 0] && h[0, 1] && h[0, 2] && h[0, 3] && h[0, 4] ||//straight across the 1st row 
            h[1, 0] && h[1, 1] && h[1, 2] && h[1, 3] && h[1, 4] ||//straight across the 2nd row
            h[2, 0] && h[2, 1] && h[2, 2] && h[2, 3] && h[2, 4] ||//straight across the 3rd row
            h[3, 0] && h[3, 1] && h[3, 2] && h[3, 3] && h[3, 4] ||//straight across the 4th row
            h[4, 0] && h[4, 1] && h[4, 2] && h[4, 3] && h[4, 4] ||//straight across the 5th row
            h[4, 0] && h[3, 0] && h[2, 0] && h[1, 0] && h[0, 0] ||//straight up the 1st column B
            h[4, 1] && h[3, 1] && h[2, 1] && h[1, 1] && h[0, 1] ||//straight up the 2nd column I
            h[4, 2] && h[3, 2] && h[2, 2] && h[1, 2] && h[0, 2] ||//straight up the 3rd column N
            h[4, 3] && h[3, 3] && h[2, 3] && h[1, 3] && h[0, 3] ||//straight up the 4th column G
            h[4, 4] && h[3, 4] && h[2, 4] && h[1, 4] && h[0, 4];  //straight up the 5th column O

        }

    }
}
