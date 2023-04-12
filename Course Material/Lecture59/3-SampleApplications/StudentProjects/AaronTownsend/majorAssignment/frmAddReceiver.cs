using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace majorAssignment
{
    public partial class frmAddReceiver : Form
    {
        public frmAddReceiver()
        {
            InitializeComponent();
        }
        /*///////////
        //Variables//
        /////////////
        Brand - represents and coincides with RECpam[].Brand
        Model - represents and coincides with RECpam[].Model
        Channels - represents and coincides with RECpam[].Channels
        WattsPerChannel - represents and coincides with RECpam[].WattsPerChannel
        HDMIinputs - represents and coincides with RECpam[].HDMIinputs
        */

        //get and set values for editing or adding new data below
        public string Brand
        {
            get { return txtBrand.Text; }
            set { txtBrand.Text = value; }
        }
        public string Model
        {
            get { return txtModel.Text; }
            set { txtModel.Text = value; }
        }
        public string Channels
        {
            get { return comboBoxChannels.Text; }
            set { comboBoxChannels.Text = value; }
        }
        public string WattsPerChannel
        {
            get { return txtWPC.Text; }
            set { txtWPC.Text = value; }
        }
        public string HDMIinputs
        {
            get { return UpDownHDMIinputs.Text; }
            set { UpDownHDMIinputs.Text = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}