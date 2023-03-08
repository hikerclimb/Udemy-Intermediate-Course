#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace FailingDivision
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // An exception (run-time error) will occur below
        // if for instance you type a word (three) instead of
        // the number (3). This would generate a FormatException
        private void divideButton_Click(object sender, EventArgs e)
        {
                double dividend = Double.Parse(dividendBox.Text);
                double divisor = Double.Parse(divisorBox.Text);

                resultBox.Text = (dividend / divisor).ToString();            
        }

        
    }
}