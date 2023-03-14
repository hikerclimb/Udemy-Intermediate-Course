using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComputerMathPitfalls
{
    public partial class FrmPitfalls : Form
    {
        public FrmPitfalls()
        {
            InitializeComponent();
        }

        private void BtnExample1_Click(object sender, EventArgs e)
        {
            decimal x = 0;

            LstDisplay.Items.Clear();
            
            while (true)
            {
                LstDisplay.Items.Add(x.ToString("n2"));

                if (x == 1)     //never test for equality when dealing with decimal #'s
                    break;      //the internal conversion from decimal to binary
                x = x + .1m;     //is not exact eg. .1 in decimal is a repeating binary dec

                if (x > 100)    //get out because you're
                    break;      //going to crash
            } 
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExample2_Click(object sender, EventArgs e)
        {
            double x = 0;

            LstDisplay.Items.Clear();
            
            while (true)
            {
                LstDisplay.Items.Add(x.ToString("n2"));

                if (x > .9)     
                    break;      
                x = x + .1;                 
            } 
        }

        private void BtnExample3_Click(object sender, EventArgs e)
        {
            double x = 0;

            LstDisplay.Items.Clear();

            while (true)
            {
                LstDisplay.Items.Add(x.ToString("n2"));

                if (Math.Abs(x-1)<=.0001)
                    break;
                x = x + .1;
            } 
        }
    }
}