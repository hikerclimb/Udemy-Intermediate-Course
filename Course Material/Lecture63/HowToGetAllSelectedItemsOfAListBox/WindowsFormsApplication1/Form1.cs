using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> selectedList = new List<string>();
            foreach (var item in ListBox1.SelectedItems)
            {
                selectedList.Add(item.ToString());
            }
            
            MessageBox.Show("Selected Items: " + Environment.NewLine +
                    string.Join(Environment.NewLine, selectedList));
            
            for (var i=0;i<selectedList.Count;i++)
            {
                MessageBox.Show(selectedList[i]);
            }
        }
    }
}
