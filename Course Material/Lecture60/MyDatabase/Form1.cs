using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contactssBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactssBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseDataSet1.Contactss' table. You can move, or remove it, as needed.
            this.contactssTableAdapter.Fill(this.myDatabaseDataSet1.Contactss);

        }
    }
}
