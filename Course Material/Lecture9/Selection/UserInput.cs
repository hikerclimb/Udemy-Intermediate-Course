﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selection
{
    public partial class UserInput : Form
    {
        public UserInput()
        {
            InitializeComponent();
        }

        public string Age
        {
            get
            {
                return TxtAge.Text;
            }
        }

        public string StudentHeight
        {
            get
            {
                return TxtHeight.Text;
            }
        }
    }
}
