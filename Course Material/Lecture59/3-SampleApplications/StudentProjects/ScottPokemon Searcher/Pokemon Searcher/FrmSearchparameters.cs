using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class FrmSearchparameters : Form
    {
        public FrmSearchparameters()
        {
            InitializeComponent();
        }

        private void FrmSearchparameters_Load(object sender, EventArgs e)
        {
            //reads specified text file made for these combo boxes
            StreamReader read = new StreamReader(Application.StartupPath + @"\info.txt");

            for (int i = 1; i <= 493 + 18; i++)
            {
                string line = read.ReadLine();

                //fills number text boxes
                if (i <= 493)
                {
                    CboNumber1.Items.Add(line);
                    CboNumber2.Items.Add(line);
                }
                //fills type text boxes
                else
                {
                    CboType1.Items.Add(line);
                    CboType2.Items.Add(line);
                }
            }
        }

        //gets number from
        public int NumberFrom
        {
            get
            {
                //returs 1 if problem
                int numberfrom = 1;

                //catches improper string to int conversions
                try
                {
                    numberfrom = Convert.ToInt32(CboNumber1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please put numerical values in combo box");
                }

                return numberfrom;
            }
        }

        //gets number to
        public int NumberTo
        {
            get
            {
                //returs 493 if problem
                int numberto = 493;

                //catches improper string to int conversions
                try
                {
                    numberto = Convert.ToInt32(CboNumber2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please put numerical values in combo box");
                }

                return numberto;
            }
        }

        //gets name search string
        public string PkmnName
        {
            get { return TxtName.Text; }
        }

        //gets type 1
        public string Type1
        {
            get { return CboType1.Text; }
        }

        //gets type 2
        public string Type2
        {
            get { return CboType2.Text; }
        }

        //gets have value
        public bool Have
        {
            get { return ChkHave.Checked; }
        }

        //gets search by have value
        public bool ByHave
        {
            get { return ChkByhave.Checked; }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void ChkByhave_CheckedChanged(object sender, EventArgs e)
        {
            //makes have checkbox enabled if search by have is checked
            ChkHave.Enabled = ChkByhave.Checked;
        }
    }
}
