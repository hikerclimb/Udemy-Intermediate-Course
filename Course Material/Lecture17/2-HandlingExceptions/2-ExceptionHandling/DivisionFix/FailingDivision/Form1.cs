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
        // C# includes three keywords to give you some control over exceptions at runtime
        // try/catch/finally
        // Anything inside a try block is code that you want to run
        // Code in the catch block only runs when something goes wrong 
        // Code in the finally block is code that must run no matter what

        private void divideButton_Click(object sender, EventArgs e)
        {
            string result = "";

            try
            {
                double dividend = Double.Parse(dividendBox.Text);
                double divisor = Double.Parse(divisorBox.Text);

                result = (dividend / divisor).ToString();
            }

            //catching specific types of exceptions
            catch (FormatException)
            {
                MessageBox.Show("You have to enter numbers into the boxes, not text");
            }                            

            //using the properties of an exception
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong : " + ex.Message);
            } 

            finally
            {
                resultBox.Text = result;
            }
        }
                
    }
}