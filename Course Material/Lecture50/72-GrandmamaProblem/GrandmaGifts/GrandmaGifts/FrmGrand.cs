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

namespace GrandmaGifts
{
    public partial class FrmGrand : Form
    {
        public FrmGrand()
        {
            InitializeComponent();
        }
        
        string [] lines;
        int[] gifts = new int[3];
        
        private void BtnGrand_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Grandmama Gift Problem Results" + Environment.NewLine + Environment.NewLine;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\gifts.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            int n = 0;
           
            WholeLine = r.ReadLine();
            n = int.Parse(WholeLine);    

            for (int i=1;i<=n;i++)
            {
                WholeLine = r.ReadLine();
                lines = WholeLine.Split(' ');

                //If we sort the gifts by price, then the smallest difference in price will either
                //be between the first two gifts or the last two gifts(If we sort them, this difference
                //will always be positive if we calculate it correctly). We can take whichever difference
                //is smaller, and print that as our answer.

                //...... BUT if we keep our gift prices as STRINGS ... as they will be when we process 
                //them into the "lines" Array above 
                //and we sort .... then "22" will be less than "4" because of the way strings are sorted

                //...... So we must convert everything to NUMBERS (int) before sorting as I am doing
                //below and resaving them into the new array called "gifts"

                for (int j = 0; j < 3; j++)
                {
                    gifts[j] = int.Parse(lines[j]);
                }                

                Array.Sort(gifts);

                int firstTwo = gifts[1] - gifts[0];
                int lastTwo = gifts[2] - gifts[1];

                int smallestDifference = Math.Min(firstTwo, lastTwo);

                TxtDisplay.Text += WholeLine + " smallest difference amounts to  " + smallestDifference.ToString() + Environment.NewLine;
            }           

            r.Close();
        }
    }
}
