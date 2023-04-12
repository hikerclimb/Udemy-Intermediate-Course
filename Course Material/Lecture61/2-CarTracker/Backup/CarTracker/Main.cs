using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarTracker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void listingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.listingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carTrackerDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carTrackerDataSet.CarType' table. You can move, or remove it, as needed.
            this.carTypeTableAdapter.Fill(this.carTrackerDataSet.CarType);
            // TODO: This line of code loads data into the 'carTrackerDataSet.Make' table. You can move, or remove it, as needed.
            this.makeTableAdapter.Fill(this.carTrackerDataSet.Make);
            // TODO: This line of code loads data into the 'carTrackerDataSet.Color' table. You can move, or remove it, as needed.
            this.colorTableAdapter.Fill(this.carTrackerDataSet.Color);
            // TODO: This line of code loads data into the 'carTrackerDataSet.Listing' table. You can move, or remove it, as needed.
            this.listingTableAdapter.Fill(this.carTrackerDataSet.Listing);

        }

        private void fillByColorNameNewToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.listingTableAdapter.FillByColorNameNew(this.carTrackerDataSet.Listing, colorNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
