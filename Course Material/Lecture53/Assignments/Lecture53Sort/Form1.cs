using System.Configuration;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lecture53Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SnowfallPerYear[] snowfall = new SnowfallPerYear[6];
        decimal[] avg = new decimal[6];

        private void BtnSortSnowfall_Click(object sender, EventArgs e)
        {
            DataFile();
            Display(ref snowfall);
            CalculateAverages(ref snowfall);
            Sort(ref snowfall);
            SortedOutput(ref avg, snowfall);
        }

        private void Sort(ref SnowfallPerYear[] data)
        {
            decimal tempAvg = 0;
            string tempCity = "";
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i + 1; j < data.Length - 1; j++)
                {
                    if (avg[i] < avg[j])
                    {
                        tempAvg = avg[i];
                        avg[i] = avg[j];
                        avg[j] = tempAvg;
                        tempCity = snowfall[i].City;
                        snowfall[i].City = snowfall[j].City;
                        snowfall[j].City = tempCity;
                    }
                }
            }
        }

        private void SortedOutput(ref decimal[] avg, SnowfallPerYear[] snowfall)
        {
            for (int i = 0; i < avg.Length - 1; i++)
            {
                TxtOutput.Text += snowfall[i].City + avg[i] + Environment.NewLine;
            }
        }

        private void DataFile()
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\snowfall.txt";

            StreamReader r = new StreamReader(f);

            int c = 0;
            string line;
            r.ReadLine();

            while ((line = r.ReadLine()) != null)
            {
                var splitSnowfall = line.Split(' ');
                snowfall[c] = new SnowfallPerYear();
                snowfall[c].City = splitSnowfall[0];
                snowfall[c].Snowfall1 = Convert.ToInt32(splitSnowfall[1]);
                snowfall[c].Snowfall2 = Convert.ToInt32(splitSnowfall[2]);
                snowfall[c].Snowfall3 = Convert.ToInt32(splitSnowfall[3]);
                snowfall[c].Snowfall4 = Convert.ToInt32(splitSnowfall[4]);
                snowfall[c].Snowfall5 = Convert.ToInt32(splitSnowfall[5]);
                snowfall[c].Snowfall6 = Convert.ToInt32(splitSnowfall[6]);
                c++;
            }
            r.Close();
        }


        private void Display(ref SnowfallPerYear[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                TxtOutput.Text += data[i].City + " ";
                TxtOutput.Text += data[i].Snowfall1 + " ";
                TxtOutput.Text += data[i].Snowfall2 + " ";
                TxtOutput.Text += data[i].Snowfall3 + " ";
                TxtOutput.Text += data[i].Snowfall4 + " ";
                TxtOutput.Text += data[i].Snowfall5 + " ";
                TxtOutput.Text += data[i].Snowfall6 + " ";
                TxtOutput.Text += Environment.NewLine;
            }
        }

        private void CalculateAverages(ref SnowfallPerYear[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                avg[i] = (data[i].Snowfall1 + data[i].Snowfall2 + data[i].Snowfall3 + data[i].Snowfall4 + data[i].Snowfall5 + data[i].Snowfall6) / 6;
            }
        }
    }
}