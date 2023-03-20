using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrivingSchoolProblem
{
    public partial class FrmDrivingSchool : Form
    {
        public FrmDrivingSchool()
        {
            InitializeComponent();
        }

        double ProbOfFailingClassTest, ProbOfFailingDrivingTest ;
        int TotalSchoolDaysForStudent, TotalSchoolDaysForAllStudents;
        string drivingstring ;

        Random r;

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            Initialize();
            Simulate();
            DisplayAverage();
        }

        private void Initialize()
        {
            ProbOfFailingClassTest = 15;    
            ProbOfFailingDrivingTest = 25;

            TotalSchoolDaysForAllStudents = 0;

            LstDisplay.Items.Clear();
        }

        private void Simulate()
        {
            r = new Random();

            for (int student=1;student<=100;student++)
            {
    
                TotalSchoolDaysForStudent = 0;
                drivingstring = "";
    
                drivingstring+= "student " + student.ToString();
        
                ClassTest();
                DrivingTest();

                LstDisplay.Items.Add(drivingstring + " -> " + TotalSchoolDaysForStudent.ToString() + " days");

            }
        }

        private void ClassTest()
        {
            while (true)
            {
                TotalSchoolDaysForStudent += 4;
                TotalSchoolDaysForAllStudents += 4;

                int d = r.Next(100) + 1;

                if (d > ProbOfFailingClassTest)
                    break;

                drivingstring += " failed class/";
            }

            drivingstring += " passed class/ ";
        }

         

        private void DrivingTest()
        {
            while (true)
            {
                TotalSchoolDaysForStudent += 10;
                TotalSchoolDaysForAllStudents += 10;

                int d = r.Next(100) + 1;

                if (d > ProbOfFailingDrivingTest)
                    break;

                drivingstring += " failed driving/";
            }
            drivingstring += " passed driving/ ";
        }

        private void DisplayAverage()
        {
            double average ;

            average = (double) TotalSchoolDaysForAllStudents / 100;
            MessageBox.Show("Average number of days to finish driving school is " + average.ToString("n2"));

        }

    }
}