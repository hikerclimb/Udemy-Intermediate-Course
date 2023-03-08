using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; 

namespace Structured_Exception_Handling
{
    public partial class frmExceptionHandlingExample : Form
    {
        public frmExceptionHandlingExample()
        {
            InitializeComponent();
        }

        private void btnCatchException_Click(object sender, EventArgs e)
        {
            long lngNumerator = 10;
            long lngDenominator = 0;
            long lngResult;

            try
            {
                lngResult = lngNumerator / lngDenominator;
            }

            catch (Exception objException)
            {
                Debug.WriteLine("Catch");
                MessageBox.Show("An error has occurred: " + objException.Message);
            }

            finally
            {
                Debug.WriteLine("Finally");
            }

            
        }
    }
}