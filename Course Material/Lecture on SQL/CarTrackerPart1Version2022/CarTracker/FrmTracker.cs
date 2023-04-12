using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTracker
{
    public partial class FrmTracker : Form
    {
        public FrmTracker()
        {
            InitializeComponent();
        }

        private void carTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carTrackerDataSet);

        }

        private void FrmTracker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carTrackerDataSet.CarType' table. You can move, or remove it, as needed.
            this.carTypeTableAdapter.Fill(this.carTrackerDataSet.CarType);

        }
    }
}
