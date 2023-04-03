using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sorting
{
    public partial class FrmSorting : Form
    {
        public FrmSorting()
        {
            InitializeComponent();
        }        

        private void BtnSelection_Click(object sender, EventArgs e)
        {
            CArray nums = new CArray(11);

            Random rnd = new Random();


            for (int i = 1; i <= 10; i++)
            {
                nums.Insert(rnd.Next(1, 101));
            }

            DisplayElements(nums);
            nums.SelectionSort();
            DisplayElements(nums);
        }

        private void DisplayElements(CArray n)
        {

            for (int i = 1; i <= n.NumElements; i++)
            {
                TxtDisplay.Text += n.arr[i].ToString() + "**";
            }
            TxtDisplay.Text += Environment.NewLine;

        }       

    }
}