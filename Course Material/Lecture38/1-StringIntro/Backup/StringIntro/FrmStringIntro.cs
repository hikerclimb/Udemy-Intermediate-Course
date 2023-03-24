using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StringIntro
{
    public partial class FrmStringIntro : Form
    {
        public FrmStringIntro()
        {
            InitializeComponent();
        }

        private void BtnLength_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(TxtString.Text.Length);
            //or             (TxtString.Text).ToString();
        }

        private void BtnSubstring1_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtString.Text.Substring(4);
        }

        private void BtnSubstring2_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtString.Text.Substring(3,5);
            //                              Substring(start,take)
        }

        private void BtnStartsWith_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(TxtString.Text.StartsWith("St"));
        }

        private void BtnEndsWith_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(TxtString.Text.EndsWith("f"));
        }

        private void BtnIndexOf_Click(object sender, EventArgs e)
        {
            TxtResult.Text=Convert.ToString(TxtString.Text.IndexOf('J'));
        }

        private void BtnToUpper_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtString.Text.ToUpper();
        }

        private void BtnToLower_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtString.Text.ToLower();
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtString.Text.Replace("e", "x");
        }


    }
}