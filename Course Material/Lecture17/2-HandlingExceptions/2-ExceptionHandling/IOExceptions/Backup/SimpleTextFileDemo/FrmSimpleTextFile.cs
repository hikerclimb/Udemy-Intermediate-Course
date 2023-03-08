using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;    //need this for StreamReader

namespace SimpleTextFileDemo
{
    public partial class FrmSimpleTextFile : Form
    {
        public FrmSimpleTextFile()
        {
            InitializeComponent();
        }

        string f;   //filename which is referenced in catch statement 
        
        private void BtnDisplayFriends_Click(object sender, EventArgs e)
        {
            string contents = "";
            
            try
            {

                string StartUpPath = Application.StartupPath;
                f = StartUpPath + @"\friend.txt";


                StreamReader r = new StreamReader(f);

                string line;
                

                while ((line = r.ReadLine()) != null)
                {
                    contents += line + Environment.NewLine;
                }

                r.Close();
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Can't Find the File " + f);
            }

            catch (IOException exc)
            {
                MessageBox.Show("IO Exception occured " + exc.Message);
            }

            finally
            {
               
                TxtDisplay.Clear();
                TxtDisplay.Text = contents;
            }
        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    
        
    }
}