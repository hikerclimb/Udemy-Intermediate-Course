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

namespace SupplementaryOOPproblems
{
    public partial class FrmOOP : Form
    {
        public FrmOOP()
        {
            InitializeComponent();
        }

        //employee is a structure of members eName and dtObirth
        struct employee
        {
            public string eName;
            public dtObirth Date;
        }
        //dtObirth is a nested structure of employee
        struct dtObirth
        {
            public int Day;
            public int Month;
            public int Year;
        }

        employee[] emp = new employee[3];

        private void BtnProblem1_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime(2010, 6, 14);
            DateTime end = new DateTime(2016, 08, 14);

            TimeSpan difference = end - start;

            MessageBox.Show("Difference in days " + difference.Days);
        }

        private void BtnStructure_Click(object sender, EventArgs e)
        {
            emp[1].eName = "Charlie";
            emp[1].Date.Day = 15;
            emp[1].Date.Month = 03;
            emp[1].Date.Year = 1959;

        }
    }
}
