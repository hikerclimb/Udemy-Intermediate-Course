using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DistanceTableLookups
{
    public partial class FrmDistanceLookups : Form
    {
        public FrmDistanceLookups()
        {
            InitializeComponent();
        }

        int[,] distance = new int[10, 10];
        string[] city = new string[10];

        private void FrmDistanceLookups_Load(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\lookups.txt";

            StreamReader read = new StreamReader(f);

            for (int r = 1; r <= 9; r++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    distance[r, c] = Convert.ToInt32(read.ReadLine());
                }
            }

            for (int r = 1; r <= 9; r++)
            {
                city[r] = read.ReadLine();
            }                      

            read.Close();

            for (int r = 1; r <= 9; r++)
            {
                CboFrom.Items.Add(city[r]);
                CboTo.Items.Add(city[r]);
            }


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLookup_Click(object sender, EventArgs e)
        {
            string FirstCityPicked = CboFrom.Text;
            string SecondCityPicked = CboTo.Text;

            if (FirstCityPicked != "" && SecondCityPicked != "")
            {
                int fcp = Search.Linear(city, FirstCityPicked, 9);
                int scp = Search.Linear(city, SecondCityPicked, 9);

                int mileage = distance[fcp, scp];

                MessageBox.Show("The distance from " + FirstCityPicked + " to " + SecondCityPicked + "  is " + mileage.ToString() + "kms");
            }
            else
            {
                MessageBox.Show("Please pick two cities");
            }

        }

    }
}