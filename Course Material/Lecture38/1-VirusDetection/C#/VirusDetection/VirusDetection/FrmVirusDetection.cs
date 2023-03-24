using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VirusDetection
{
    public partial class FrmVirusDetection : Form
    {
        public FrmVirusDetection()
        {
            InitializeComponent();
        }

        private void BtnVirusDetection_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\virus.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    if (DetectVirus(line))
                    {
                        TxtDisplay.Text += line + " *** has an occurence of the string - virus ***" + Environment.NewLine;
                    }
                }
            }
        }

        private bool DetectVirus(string virustext)
        {
            bool status = false;

            string lower = virustext.ToLower();
            
            int v = lower.IndexOf('v');
            if (v == -1)
                return status;

            lower = lower.Substring(v);

            int i = lower.IndexOf('i');
            if (i == -1)
                return status;

            lower = lower.Substring(i);

            int r = lower.IndexOf('r');
            if (r == -1)
                return status;

            lower = lower.Substring(r);

            int u = lower.IndexOf('u');
            if (u == -1)
                return status;

            lower = lower.Substring(u);

            int s = lower.IndexOf('s');
            if (s==-1)
            {
                return status;
            }
            else 
            {
                status=true;
                return status;
            }
            
        }
    }
}