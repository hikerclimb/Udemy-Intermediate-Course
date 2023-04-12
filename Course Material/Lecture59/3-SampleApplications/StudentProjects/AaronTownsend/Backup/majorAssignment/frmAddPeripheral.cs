using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace majorAssignment
{
    public partial class frmAddPeripheral : Form
    {
        public frmAddPeripheral()
        {
            InitializeComponent();
        }

        /*///////////
        //Variables//
        /////////////
        Type - represents and coincides with PERIPHpam[].Type
        Brand - represents and coincides with PERIPHpam[].Brand
        Name - represents and coincides with PERIPHpam[].Name
        */

        //get and set values for editing or adding new data below
        public string Type
        {
            get { return txtType.Text; }
            set { txtType.Text = value; }
        }
        public string Brand
        {
            get { return txtBrand.Text; }
            set { txtBrand.Text = value; }
        }
        public string Name
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}