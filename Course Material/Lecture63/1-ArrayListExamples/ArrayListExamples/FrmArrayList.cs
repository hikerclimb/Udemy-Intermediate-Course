using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;       //need to add to use ArrayList and List

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
            //weakly typed data structure
            //must cast to and from an Object

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

        private void BtnList_Click(object sender, EventArgs e)
        {
            //List.
            //There are 3 strings.
            //Then there are 9.
            //Now 900.With a List we add any number of elements. 
            //Its internal buffer resizes on its own.

            //List has methods that search for and change data.
            //It is ideal for elements accessed by indexes.
            //It is an optimized ArrayList.

            //List < T > is a generic class.
            //It supports storing values of a specific type without casting to or from object
            //ArrayList belongs to the days that C# didn't have generics. 
            //It's deprecated in favor of List<T>.

            TxtDisplay.Clear();

            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(7);

            foreach (int prime in list) // Loop through List with foreach.
            {
                TxtDisplay.Text += prime.ToString() + Environment.NewLine;
            }

            TxtDisplay.Text +=Environment.NewLine;

            for (int i = 0; i < list.Count; i++) // Loop with for.
            {
                TxtDisplay.Text += list[i] + Environment.NewLine; 
            }

        }

        private void BtnBinarySearch_Click(object sender, EventArgs e)
        {
            List<string> l = new List<string>();
            l.Add("acorn");      // 0
            l.Add("apple");      // 1
            l.Add("banana");     // 2
            l.Add("cantaloupe"); // 3
            l.Add("lettuce");    // 4
            l.Add("onion");      // 5
            l.Add("peach");      // 6
            l.Add("pepper");     // 7
            l.Add("squash");     // 8
            l.Add("tangerine");  // 9

            TxtDisplay.Clear();
            foreach (string fruits in l) // Loop through List with foreach.
            {
                TxtDisplay.Text += fruits.ToString() + Environment.NewLine;
            }


            // This returns the index of "peach".
            int i = l.BinarySearch("peach");
            TxtDisplay.Text += "Peach is in location " + i.ToString() + Environment.NewLine;
            

            // This returns the index of "banana".
            i = l.BinarySearch("banana");
            TxtDisplay.Text += "Banana is in location " + i.ToString() + Environment.NewLine;

            
        }
    }
}