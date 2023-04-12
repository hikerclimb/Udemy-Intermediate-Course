using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsDBexample
{
    public partial class FrmDatabase : Form
    {
        public FrmDatabase()
        {
            InitializeComponent();
        }

        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FrmDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.database1DataSet.Contacts);

        }
    }
}
