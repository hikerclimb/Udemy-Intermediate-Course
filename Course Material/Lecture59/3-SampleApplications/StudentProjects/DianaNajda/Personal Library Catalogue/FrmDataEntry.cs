using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Personal_Library_Catalogue
{
    public partial class FrmDataEntry : Form
    {
        public FrmDataEntry()
        {
            InitializeComponent();
        }
        //set: sets the text in the text box to 
        //whatever the value that was sent over
        //from the other form was

        //get: returns the value in the textbox 
        //back to the main form

        public string Title
        {
            set { txtTitle.Text = value; }
            get { return txtTitle.Text; }
        }

        public string Author
        {
            set { txtAuthor.Text = value; }
            get { return txtAuthor.Text ;}
        }

        public string Year
        {
            set { txtYear.Text = value; }
            get { return txtYear.Text; }
        }

        public string Genre
        {
            set { txtGenre.Text = value; }
            get { return txtGenre.Text; }
        }

        public string Info
        {
            set { txtInfo.Text = value; }
            get { return txtInfo.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tried to create a way so that users could search
            //info about the book they are entering/editing right in the program

            //System.Object nullObject = 0;
            //string str = "";
            //System.Object nullObjStr = str;
            //Cursor.Current = Cursors.WaitCursor;
            //webBrowser1.Navigate(textBox1.Text, ref nullObject, ref nullObjStr, ref nullObjStr, ref nullObjStr);
            //Cursor.Current = Cursors.Default;

        }
    }
}