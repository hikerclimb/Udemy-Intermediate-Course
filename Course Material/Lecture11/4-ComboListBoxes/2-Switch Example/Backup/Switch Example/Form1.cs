using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Switch_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowLegs_Click(object sender, EventArgs e)
        {
            switch (cboAnimals.Text)
            {
                case "Bird":
                    MessageBox.Show("The animal has 2 legs.");
                    break;
                case "Dog":
                // Notice there is no code here to execute.
                case "Cat":
                    MessageBox.Show("The animal has 4 legs.");
                    break;
                case "Snake":
                    MessageBox.Show("The animal has no legs.");
                    break;
                case "Centipede":
                    MessageBox.Show("The animal has 100 legs.");
                    break;
                default:
                    MessageBox.Show("You did not select from the list!");
                    break;
            }

        }
    }
}