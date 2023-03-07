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


namespace Epidemiology
{
    public partial class FrmVirus : Form
    {
        public FrmVirus()
        {
            InitializeComponent();
        }

        private void BtnVirus_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\virus.txt";

            StreamReader r = new StreamReader(f);

            string line;

            //P - We are trying to determine the number of days it days to 
            //    have more than P people have the disease
            //N - The number of people who have the disease on day 0
            //R - The number of OTHER people infected the next day
            int P, N, R;
            
            bool finished = false;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    P = int.Parse(line);
                    N = int.Parse(r.ReadLine());
                    R = int.Parse(r.ReadLine());

                    TxtDisplay.Text += "Total number of days to reach " + P.ToString() + " " +
                        "Infected is " + Infected(P,N,R) +  Environment.NewLine;                    
                }
            }
        }

        private int Infected(int p,int n, int r)
        {
            int DayCount = 0;

            int Infected = n;
            int TotalInfected = n;

            while (true)
            {
                TotalInfected = TotalInfected + Infected * r;   //total number infected
                Infected = Infected * r;                        //new people infected that can
                DayCount++;                                     //spread the virus to r new people

                if (TotalInfected >= p)
                {
                    if (TotalInfected==p)
                    {
                        DayCount++;
                    }

                    break;
                }
            }

            return DayCount;
        }
    }
}
