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

namespace CallingAllCars
{
    public partial class FrmCalling : Form
    {
        public FrmCalling()
        {
            InitializeComponent();
        }

        //declare arrays
        string[] lines;
        string[] police; //police car name
        int[] xpos;      //x position of police car
        int[] ypos;      //y position of police car

        private void BtnCalling_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\cars.txt";

            StreamReader read = new StreamReader(f);
           
            string WholeLine;

            //read in the first two numbers ... number of police cars and incidents
            WholeLine = read.ReadLine();
            lines = WholeLine.Split(' ');
            
            int m = int.Parse(lines[0]);
            int n = int.Parse(lines[1]);

            //size the array
            xpos = new int[m];
            ypos = new int[m];
            police = new string[m];

            //now read in the specific locations for each of the police cars
            for (int k = 0; k <m; k++)
            {
                WholeLine = read.ReadLine();
                lines = WholeLine.Split(' ');
                police[k] = lines[0];
                xpos[k] = int.Parse(lines[1]);
                ypos[k] = int.Parse(lines[2]);
            }

            //cycle through all the incidents locations
            for (int k=0;k<n;k++)
            {
                WholeLine = read.ReadLine();
                lines = WholeLine.Split(' ');
                int x = int.Parse(lines[0]);
                int y = int.Parse(lines[1]);

                //we are trying to find the smallest distance 
                //so initialize our variable to opposite extremes
                int nearestIndex = -1;
                double nearestDistance = 20000.00;

                //see which one of the police cars is the closest to the incident location above
                for (int i=0;i<m;i++)
                {

                    double d = Distance(x, y, xpos[i], ypos[i]);

                    if (d< nearestDistance)
                    {
                        nearestIndex = i;
                        nearestDistance = d;
                    }
                }

                TxtDisplay.Text += police[nearestIndex] + Environment.NewLine;

                //change the position of the closest car to its new position for the next possible car
                xpos[nearestIndex] = x;
                ypos[nearestIndex] = y;
            }               
            
            read.Close();
        }

        private double Distance(int x1,int y1,int x2,int y2)
        {
            //Basically using the Pythagorean Theorem
            return Math.Sqrt(Math.Pow(x1 - x2, 2.0) + Math.Pow(y1 - y2, 2.0));
        }
    }
}
