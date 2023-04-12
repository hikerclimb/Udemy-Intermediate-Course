using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;       //need to add to use ArrayList

namespace ArrayListExamples
{
    public partial class FrmArrayList : Form
    {
        public FrmArrayList()
        {
            InitializeComponent();
        }
        

        private void BtnOne_Click(object sender, EventArgs e)
        {
            ArrayList grades = new ArrayList();
            
            grades.Add(100);
            grades.Add(84);

            int position = grades.Add(77);
            MessageBox.Show("The grade 77 was added at position " + position);

            foreach (Object grade in grades)
            {
                TxtDisplay.Text += grade.ToString() + Environment.NewLine;
            }

            int total = 0;
            double average = 0.0;

            foreach (Object grade in grades)
            {
                total += (int)grade;
            }

            average = total / grades.Count;

            TxtDisplay.Text += "Average grade is " + average.ToString("n2");

            grades.Insert(1, 99); //insert grade 99 at position 1 (2nd in list)

            if (grades.Contains(84))
            {
                grades.Remove(84);
            }
            else
            {
                MessageBox.Show("Object not in ArrayList");
            }
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            ArrayList names = new ArrayList();

            names.Add("Mike");
            names.Add("Beata");
            names.Add("Raymond");
            names.Add("Bernica");
            names.Add("Jennifer");

            TxtDisplay.Clear();

            TxtDisplay.Text += "The Original List" + Environment.NewLine;

            foreach (Object name in names)
            {
                TxtDisplay.Text += name + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;

            string[] newNames = { "David", "Michael" };

            ArrayList moreNames = new ArrayList();

            moreNames.Add("Terrill");
            moreNames.Add("Donnie");
            moreNames.Add("Mayo");
            moreNames.Add("Clayton");
            moreNames.Add("Alisa");

            names.InsertRange(0, newNames);
            names.AddRange(moreNames);

            TxtDisplay.Text += "The New List" + Environment.NewLine;

            foreach (Object name in names)
            {
                TxtDisplay.Text += name + Environment.NewLine;
            }

        }
    }
}