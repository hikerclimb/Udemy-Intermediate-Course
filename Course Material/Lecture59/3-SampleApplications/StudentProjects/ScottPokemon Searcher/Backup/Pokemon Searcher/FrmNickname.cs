using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmNickname : Form
    {
        public FrmNickname()
        {
            InitializeComponent();
        }

        //gets nickname
        public string Nickname
        {
            get { return TxtNickname.Text; }
        }

        //gets boolean on if nickname should be used or not
        public bool Use
        {
            get { return !ChkNickname.Checked; }
        }

        //gets shiny value
        public bool Shiny
        {
            get { return ChkShiny.Checked; }
        }

        private void ChkNickname_CheckedChanged(object sender, EventArgs e)
        {
            //disables nickname textbox if there is no nickname to be used
            TxtNickname.Enabled = !ChkNickname.Checked;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }
    }
}
