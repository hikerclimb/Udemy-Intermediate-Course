using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class FrmSelect : Form
    {
        public FrmSelect()
        {
            InitializeComponent();
        }

        //***********************************************************//
        //***VARIABLE DICTIONARY*************************************//
        //***Lib[] - array for Library Info holding all books data***//
        //***c - counter for amount of books*************************//
        //***loc - place holder for deleted or edited entry**********//
        //***action - string that holds which action took place******//
        //***********************************************************//

        // initalize variables
        LibraryInfo[] Lib = new LibraryInfo[200];

        int c = 0;
        int loc = 0;

        string action = "Add";

        private void FrmSelect_Load(object sender, EventArgs e)
        {
            // add items to CboStatus
            CboStatus.Items.Add("IN");
            CboStatus.Items.Add("OUT");
        }

        public string Clear
        {
            set
            {
                if (value == "True")
                {
                    // reset all values on the form
                    c = 0;
                    BtnAdd.Enabled = true;
                    BtnEdit.Enabled = true;
                    BtnDelete.Enabled = true;
                    cboNames.Visible = true;
                    BtnCancel.Text = "Cancel";
                    cboNames.Items.Clear();
                    cboNames.Text = "";
                    TxtAuthor2.Text = "";
                    TxtBookName2.Text = "";
                    TxtGenre.Text = "";
                    TxtPublishDate2.Text = "";
                    CboStatus.Items.Clear();
                    CboStatus.Text = "";
                }
            }
        }
        public string MainPanel
        {
            // set PnlMain visibility based on boolean value from FrmLibrary
            set { PnlMain.Visible = Convert.ToBoolean(value); }
        }

        public string Search
        {
            set
            {
                if (int.Parse(value) == 1) // if the loading of this form is for a search result
                {
                    // hide all administrative priveledges
                    cboNames.Visible = false;
                    BtnAdd.Enabled = false;
                    BtnEdit.Enabled = false;
                    BtnDelete.Enabled = false;
                    BtnCancel.Text = "OK";
                }
            }
        }

        public string Names
        {
            set
            {
                // clear previous Lib[] values
                Lib[c] = new LibraryInfo();
                Lib[c].BookName = "";
                Lib[c].Author = "";
                Lib[c].PublishDate = "";
                Lib[c].Genre = "";
                Lib[c].Status = "";
                Lib[c].Max = 0;

                // add book name value from FrmLibrary to cbonames
                cboNames.Items.Add(value);

                // add book name value from FrmLibrary to respective property in array
                Lib[c].BookName = value;
            }
        }

        public string Author
        {
            // set author value from FrmLibrary to respective property in array
            set { Lib[c].Author = value; }
        }

        public string PublishDate
        {
            // set publish date value from FrmLibrary to respective property in array
            set { Lib[c].PublishDate = value; }
        }

        public string Genre
        {
            // set genre value from FrmLibrary to respective property in array
            set { Lib[c].Genre = value; }
        }

        public string Status
        {
            // set status value from FrmLibrary to respective property in array
            set { Lib[c].Status = value; c++;}
        }

        public string BookName
        {
            // return BookName to FrmLibrary from textbox
            get { return TxtBookName2.Text; }
            set { TxtBookName2.Text = value; }
        }

        public string BookAuthor
        {
            // return BookAuthor to FrmLibrary from textbox
            get { return TxtAuthor2.Text; }
            set { TxtAuthor2.Text = value; }
        }

        public string BookPublishDate
        {
            // return BookPublishDate to FrmLibrary from textbox
            get { return TxtPublishDate2.Text; }
            set { TxtPublishDate2.Text = value; }
        }

        public string BookGenre
        {
            // return BookGenre to FrmLibrary from textbox
            get { return TxtGenre.Text; }
            set { TxtGenre.Text = value; }
        }

        public string BookStatus
        {
            // return BookStatus to FrmLibrary from textbox
            get { return CboStatus.Text; }
            set { CboStatus.Text = value; }
        }

        public string Action
        {
            // send action string to FrmLibrary to determine which action is to be made
            get { return action; }
        }

        public string EditLoc
        {
            // send location in array to FrmLibrary to keep position for Editing and Deleting the proper entry
            get { return loc.ToString(); }
        }

        private void TxtGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // determine which keys can be pressed in TxtGenre
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == ' ' || e.KeyChar == 8)
            {
                e.Handled = false; // allow only the certain characters
            }
            else
            {
                e.Handled = true;
            }

            //If an unacceptable key is detected, we set 
            //e.Handled to true.  This ‘tricks’ Visual C# Express
            //into thinking the KeyPress event has already been
            //handled and the pressed key is ignored. 
            //If a pressed key is acceptable, we set
            //the e.Handled property to false. 
            //This tells Visual C# Express that this
            //method has not been handled and the
            //KeyPress should be allowed 
            //(by default, e.Handled is false, allowing 
            //all keystrokes).
        }

        private void TxtAuthor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // determine which keys can be pressed in TxtAuthor2
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == ' ' || e.KeyChar == 8)
            {
                e.Handled = false; // allow only the certain characters
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtBookName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // determine which keys can be pressed in TxtBookName2
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == ' ' || e.KeyChar == 8)
            {
                e.Handled = false; // allow only the certain characters
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextPublishDate2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // determine which keys can be pressed in TxtPublishDate2
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == ' ' || e.KeyChar == 8)
            {
                e.Handled = true; // allow only the certain characters
            }
            else
            {
                e.Handled = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            action = "Add"; // sets action string to add
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            action = "Edit"; // sets action string to edit
        }

        private void cboNames_TextChanged(object sender, EventArgs e)
        {
            // find location in array for booknames that matches the book name in the textbox
            for (int i = 1; i <= c - 1; i++)
            {
                if (Lib[i].BookName == cboNames.Text)
                {
                    loc = i; // save location
                }
            }

            // set textbox texts to match the data in the array for chosen book
            TxtBookName2.Text = Lib[loc].BookName;
            TxtAuthor2.Text = Lib[loc].Author;
            TxtGenre.Text = Lib[loc].Genre;
            TxtPublishDate2.Text = Lib[loc].PublishDate;
            CboStatus.Text = Lib[loc].Status;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            action = "Delete"; // set action as delete
        }

        private void CboStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // do not allow keypresses in cbostatus
        }

        private void cboNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // do not allow keypresses in cbonames
        }
    }
}