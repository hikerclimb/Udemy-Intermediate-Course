using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        public string Username
        {
            // get username from TxtUsername to send back to FrmLibrary
            get { return TxtUsername.Text; }
        }

        public string Password
        {
            // get password from TxtPassword to send back to FrmLibrary
            get { return TxtPassword.Text; }
        }
    }
}