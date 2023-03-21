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

namespace MagicDates
{
    public partial class FrmDates : Form
    {
        public FrmDates()
        {
            InitializeComponent();
        }

        string[] lines;
       
        private void BtnDates_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Date Results" + Environment.NewLine + Environment.NewLine;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\magic.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine1;
            string WholeLine2;

            bool finished = false;

            int firstmonth, firstday, firstyear;
            int secondmonth, secondday, secondyear;
            
            string days;
            int newdays;

            while (!finished)
            {
                WholeLine1 = r.ReadLine();

                if (WholeLine1 == null)
                {
                    finished = true;
                }
                else
                {
                    WholeLine2 = r.ReadLine();

                    lines = WholeLine1.Split(' ');
                    firstmonth = int.Parse(lines[0]);
                    firstday = int.Parse(lines[1]);
                    firstyear = int.Parse(lines[2]);

                    lines = WholeLine2.Split(' ');
                    secondmonth = int.Parse(lines[0]);
                    secondday = int.Parse(lines[1]);
                    secondyear = int.Parse(lines[2]);

                    //First solution relies on built-in DateTime functions ... quick and simple
                    days = ElapsedDays(firstmonth, firstday, firstyear, secondmonth, secondday, secondyear);
                    TxtDisplay.Text += "Elapsed days is " + days + Environment.NewLine;

                    //Second solution does not use any built-in functions ... not so quick ... not so simple
                    newdays = NewElapsedDays(firstmonth, firstday, firstyear, secondmonth, secondday, secondyear);
                    TxtDisplay.Text += "New Elapsed days is " + days + Environment.NewLine;
                }
            }
        }

        private string ElapsedDays(int fm,int fd,int fy, int sm,int sd,int sy)
        {
            System.DateTime firstDate = new System.DateTime(fy, fm, fd);
            System.DateTime secondDate = new System.DateTime(sy, sm, sd);

            //System.TimeSpan diff = secondDate.Subtract(firstDate);
            //System.TimeSpan diff1 = secondDate - firstDate;

            String diff2 = (secondDate - firstDate).TotalDays.ToString();
            
            return diff2;
        }

        private int NewElapsedDays(int fm, int fd, int fy, int sm, int sd, int sy)
        {

            int days = DaysSinceJan1_1900(sm, sd, sy) - DaysSinceJan1_1900(fm, fd, fy);
            return days;

        }

        private int DaysSinceJan1_1900(int month, int day, int year)
        {
            int numDays = 0;
            
            numDays += DaysBetweenYears(1900, year);
            numDays += DaysSinceJan1(month, day, year);
            
            return numDays;
        }

        private int DaysBetweenYears(int year1, int year2)
        {
            int numDays = 0;

            for (int year = year1; year < year2; year++)
            {
                if ((year % 4 == 0 && year % 100 != 0) ||
                (year % 400 == 0))
                {
                    numDays += 366;
                }
                else
                {
                    numDays += 365;
                }
            }

            return numDays;
        }

        private int DaysSinceJan1(int month, int day, int year)
        {
            int numDays = 0;
            for (int i = 1; i < month; i++)
            {
                if (i == 4 || i == 6 || i == 9 || i == 11)
                    numDays += 30;
                else if (i == 2 && ((year % 400 == 0) ||
                        (year % 4 == 0 && year % 100 != 0)))
                    numDays += 29;
                else if (i == 2)
                    numDays += 28;
                else
                    numDays += 31;
            }

            numDays += (day - 1);
            return numDays;
        }
    }
}
