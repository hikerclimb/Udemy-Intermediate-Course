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

namespace PriceDecline
{
    public partial class FrmPrice : Form
    {
        public FrmPrice()
        {
            InitializeComponent();
        }

        string[] lines;

        private void BtnPrice_Click(object sender, EventArgs e)
        {
            string s = Application.StartupPath;
            string f = s + @"\prices.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            
           
            //neat way to read and check for null line all in one step
            while ((WholeLine = r.ReadLine()) != null)
            {
                             
                lines = WholeLine.Split(' ');

                int p = int.Parse(lines[0]);
                int a = int.Parse(lines[1]); 
                int b = int.Parse(lines[2]);
                int c = int.Parse(lines[3]);
                int d = int.Parse(lines[4]);
                int n = int.Parse(lines[5]);

                double[] prices = new double[n];

                //calculate prices for n values using cost function (method)
                for (int i=0;i<n;i++)
                {
                    prices[i] = cost(i + 1, p, a, b, c, d);
                }

                //call the BiggestDecline method that will return the biggest drop in price 
                double decline = BiggestDecline(prices, n);

                TxtDisplay.Text += decline.ToString("n3") + Environment.NewLine;

            }

            r.Close();
        }

        private double cost(int k, int p, int a, int b, int c, int d)
        {
            double price = 0.0;
            price = p * (Math.Sin(a * k + b) + Math.Cos(c * k + d) + 2);
            return price;

        }

        private double BiggestDecline (double [] p,int n)
        {
            //basically we are determining the largest and smallest prices and taking
            //the difference

            double biggest = 0.0;
            double maxSoFar = p[0];
            double curMin = p[0];

            for (int i=1;i<n;i++)
            {
                if (p[i] > maxSoFar)
                {
                    maxSoFar = p[i];
                    curMin = p[i];

                }
                if (p[i] < curMin)
                {
                    curMin = p[i];
                }

                 if (maxSoFar-curMin > biggest)
                {
                    biggest = maxSoFar - curMin;
                }
            }

            return biggest; 
        }
    }
}
