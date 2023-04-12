using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace majorAssignment
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // exits the About form
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            //reads Info about this program from a .dat file so the code is not  overrun with text
            textBoxInfo.Text = "This is my major assignment submission for my computer science class. It is a program which displays a list of televisions or computer monitors. This allows a user to analyze which is best for them based on various factors. Custom display lists can be created and all data files can be modified. Sorting can be done by clicking on the column headers when a data file is loaded. Deleting can be accomplished by clicking on data and hitting either delete or the delete button.";
            
            System.Web.HttpUtility.UrlEncode("http://aaron-townsend.blogspot.com/");
            System.Web.HttpUtility.UrlEncode("http://whizard.net/");

            linkLabelAuthor.Text = "Aaron Townsend"; // set the name of the link
            linkLabelAuthor.Links.Add(0, 14, "http://aaron-townsend.blogspot.com/"); // set the link destination

            linkLabelHomePage.Text = "whizard.net"; // set the name of the link
            linkLabelHomePage.Links.Add(0, 11, "http://whizard.net/"); // set the link destination
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Change the color of the link text by setting LinkVisited to true.
                linkLabelAuthor.LinkVisited = true;
                //Call the Process.Start method to open the default browser with a URL:
                System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to open link that was clicked" + exp.Message,"Link Error");
            }
        }

        private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Change the color of the link text by setting LinkVisited to true.
                linkLabelHomePage.LinkVisited = true;
                //Call the Process.Start method to open the default browser with a URL:
                System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to open link that was clicked" + exp.Message, "Link Error");
            }
        }
    }
}