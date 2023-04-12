using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace majorAssignment
{
    public partial class frmAddSpeakers : Form
    {
        public frmAddSpeakers()
        {
            InitializeComponent();
        }
        /*///////////
        //Variables//
        /////////////
        Brand - represents and coincides with SPKRpam[].Brand
        Model - represents and coincides with SPKRpam[].Model
        Type - represents and coincides with SPKRpam[].Type
        SpeakerFrequencyResponse - represents and coincides with SPKRpam[].SpeakerFrequencyResponse
        SpeakerPower - represents and coincides with SPKRpam[].SpeakerPower
        SubwooferPower - represents and coincides with SPKRpam[].SubwooferPower
        SubwooferDriveComponents - represents and coincides with SPKRpam[].SubwooferDriveComponents
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
        public string Type
        {
            get { return txtType.Text; }
            set { txtType.Text = value; }
        }
        public string SpeakerFrequencyResponse
        {
            get { return txtSFR.Text; }
            set { txtSFR.Text = value; }
        }
        public string SpeakerPower
        {
            get { return txtSP.Text; }
            set { txtSUBP.Text = value; }
        }
        public string SubwooferPower
        {
            get { return txtSUBP.Text; }
            set { txtSUBP.Text = value; }
        }
        public string SubwooferDriveComponents
        {
            get { return txtSDC.Text; }
            set { txtSDC.Text = value; }
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}