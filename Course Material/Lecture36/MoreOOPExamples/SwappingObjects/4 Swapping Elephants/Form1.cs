using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __Swapping_Elephants
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;

        public Form1()
        {
            InitializeComponent();

            lucinda = new Elephant(33,"Lucinda");
            lloyd = new Elephant(40,"Lloyd");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Here we perform the classic swap (recall sorting)

            Elephant holder;    //a temp object required for swapping

            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;

            MessageBox.Show("Objects swapped");
        }

    }

}