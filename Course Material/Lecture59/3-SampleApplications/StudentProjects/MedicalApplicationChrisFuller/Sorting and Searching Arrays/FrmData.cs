using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sorting_and_Searching_Arrays
{
    public partial class FrmData : Form
    {
        public FrmData()
        {
            InitializeComponent();
        }

        public string PatName
        {
            get { return TxtName.Text; }
            set { TxtName.Text = value; }
        }
        public string Age
        {
            get { return TxtAge.Text; }
            set { TxtAge.SelectedText = value; }
        }
        public string Sex
        {
            get {
                if (ChkFemale.Checked == true)
                return "Female";
                else
                return "Male";
            
            }
            set {
                if (value == "Male")
                    ChkMale.Checked = true;
                else if (value == "Female")
                    ChkFemale.Checked = true;
            
            }
        }
        public string RmNum
        {
            get { return TxtRmNum.Text; }
            set { TxtRmNum.Text = value; }
        }
        //public string Picture
        //{
        //    get { return Picture.Text; }
        //    set { Picture.Text = value; }
        //}
        public string XtraCons
        {
            get { return TxtXtraCons.Text; }
            set { TxtXtraCons.Text = value; }
        }
        public string Reason
        {
            get { return TxtReason.Text; }
            set { TxtReason.Text = value; }
        }

        private void FrmData_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 150; i++)
            {
                TxtAge.Items.Add(i);
            }
        }

        private void TxtRmNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Temp = TxtRmNum.Text;

        if (Char.IsNumber(e.KeyChar) != true){
            if (e.KeyChar == 8)
            {
            }
            else
            {
                e.Handled = true;
            }
            }

           if (Char.IsNumber(e.KeyChar) == true && Temp.Length >2){
                e.Handled= true;
            }
 //|| Char.IsNumber(e.KeyChar) && Temp.Length >2)
           
        }
        }
    }