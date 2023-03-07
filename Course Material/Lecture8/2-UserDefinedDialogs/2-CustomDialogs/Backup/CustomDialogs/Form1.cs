using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getNameButton_Click(object sender, EventArgs e)
        {
            Dialog nameDialog = new Dialog();
            
            DialogResult r = nameDialog.ShowDialog();

            if (r == DialogResult.OK)
            {
                MessageBox.Show(nameDialog.UserName);
            }

            //if (nameDialog.ShowDialog() == DialogResult.OK)
            //{
            //  MessageBox.Show(nameDialog.UserName);
            //}
        }
    }
}