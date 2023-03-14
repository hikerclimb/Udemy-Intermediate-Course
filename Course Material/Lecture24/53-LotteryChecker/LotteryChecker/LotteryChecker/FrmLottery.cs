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

namespace LotteryChecker
{
    public partial class FrmLottery : Form
    {
        public FrmLottery()
        {
            InitializeComponent();
        }

        string[] lines;
        int [] winningnumbers = new int[8];
        int [,] numberspicked = new int[6,7];
	    int [] winnings = new int[6];
        int [] bonus = new int[6];
        int picked, bonuses;


        private void BtnLottery_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\lottery.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;

            WholeLine = r.ReadLine();

            lines = WholeLine.Split(' ');

            //read in the 6 winning numbers and the bonus number
            for (int cell = 1; cell <= 7; cell++)
            {
                winningnumbers[cell] = int.Parse(lines[cell - 1]);
            }

            //read in the players 5 ticket number choices and store the values
            //in the 2d array 
            for (int a = 1; a <= 5; a++)
            {
                WholeLine = r.ReadLine();
                lines = WholeLine.Split(' ');

                for (int b = 1; b <= 6; b++)
                {
                    numberspicked[a, b] = int.Parse(lines[b - 1]);
                }
            }

            for (int a=1;a<=5;a++)
            {
                picked = 0;
                bonuses = 0;

                for (int b=1;b<=7;b++)
                {
                    for (int c=1;c<=6;c++)
                    {
                        if (winningnumbers[b]==numberspicked[a,c])
                        {
                            if (b==7) //remember last number is bonus
                            {
                                bonuses++;
                            }
                            else
                            {
                                picked++;
                            }
                        }
                    }
                }

                winnings[a] = picked;
                bonus[a] = bonuses;
            }

            for (int a=1;a<=5;a++)
            {
                if (winnings[a]<=2)
                {
                    TxtDisplay.Text += "No Prize" + Environment.NewLine;
                }
                else if (winnings[a] == 3)
                {
                    TxtDisplay.Text += "Fifth prize" + Environment.NewLine;
                }
                else if (winnings[a]==4)
                {
                    TxtDisplay.Text += "Fourth prize" + Environment.NewLine;
                }
                else if (winnings[a]==5 && bonus[a]>0)
                {
                    TxtDisplay.Text += "Second prize" + Environment.NewLine;
                }
                else if (winnings[a]==5)
                {
                    TxtDisplay.Text += "Third prize" + Environment.NewLine;
                }
                else if (winnings[a]==6)
                {
                    TxtDisplay.Text += "First prize";
                }
            }
        }
    }
}
