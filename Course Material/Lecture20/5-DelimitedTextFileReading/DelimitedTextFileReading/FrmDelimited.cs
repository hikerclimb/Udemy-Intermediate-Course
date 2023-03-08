using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DelimitedTextFileReading
{
    public partial class FrmDelimited : Form
    {
        public FrmDelimited()
        {
            InitializeComponent();
        }

        string[] first = new string[20];
        string[] last = new string[20];
        string[] lines;                 //needed for split command

        int c, n;

        private void BtnRead_Click(object sender, EventArgs e)
        {
            c = 0;
            n = 0;

            string s = Application.StartupPath;
            string f = s+ @"\names.txt";
            StreamReader r = new StreamReader(f);

            string WholeLine;

            while ( (WholeLine=r.ReadLine())!=null )
            {
                c++;
                lines = WholeLine.Split(' '); //contents of WholeLine separated based
                                              //on blank space and each part stored
                first[c]=lines[0];            //into ARRAY lines
                last[c]=lines[1];
            }

            r.Close();
            n=c;

            DisplayResults();
        }

        private void DisplayResults()
        {
            for (int i=1;i<=n;i++)
            {
                LstDisplay.Items.Add(first[i]+ "\t" + last[i]);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}