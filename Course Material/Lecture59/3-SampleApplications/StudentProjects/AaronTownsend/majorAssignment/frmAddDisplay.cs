using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace majorAssignment
{
    public partial class frmAddDisplay : Form
    {
        public frmAddDisplay()
        {
            InitializeComponent();
        }
        /*///////////
        //Variables//
        /////////////
            PartNum - represents and coincides with TVpam[].PartNumber
            Brand - represents and coincides with TVpam[].Brand
            AspectRatio - represents and coincides with TVpam[].AspectRatio
            DispCap - represents and coincides with TVpam[].DisplayCapabilities
            DispTech - represents and coincides with TVpam[].DisplayTechnology
            DCR - represents and coincides with TVpam[].DynamicContrastRatio
            Resolution - represents and coincides with TVpam[].NativeResolution
            RefreshRate - represents and coincides with TVpam[].RefreshRate
            ResponseTime - represents and coincides with TVpam[].ResponseTime
            ScreenSize - represents and coincides with TVpam[].ScreenSize
         */

        //get and set values for editing or adding new data below
        public string PartNum
        {
            get { return txtPN.Text; }
            set { txtPN.Text = value; }
        }
        public string Brand
        {
            get { return comboBoxBrand.Text; }
            set { comboBoxBrand.Text = value; }
        }
        public string AspectRatio
        {
            get { return txtDCR.Text; }
            set { txtDCR.Text = value; }
        }
        public string DispCap
        {
            get { return comboBoxCap.Text; }
            set { comboBoxCap.Text = value; }
        }
        public string DispTech
        {
            get { return comboBoxTech.Text; }
            set { comboBoxTech.Text = value; }
        }
        public string DCR
        {
            get { return txtDCR.Text; }
            set { txtDCR.Text = value; }
        }
        public string Resolution
        {
            get { return txtRes.Text; }
            set { txtRes.Text = value; }
        }
        public string RefreshRate
        {
            get { return txtRate.Text; }
            set { txtRate.Text = value; }
        }
        public string ResponseTime
        {
            get { return UpDownTime.Text; }
            set { UpDownTime.Text = value; }
        }
        public string ScreenSize
        {
            get { return UpDownSize.Text; }
            set { UpDownSize.Text = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}