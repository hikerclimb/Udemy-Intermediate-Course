using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PatientInfo
{
    public partial class FrmOther : Form
    {
        public FrmOther()
        {
            InitializeComponent();
        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalClass.GlobalVar);
        }
    }
}