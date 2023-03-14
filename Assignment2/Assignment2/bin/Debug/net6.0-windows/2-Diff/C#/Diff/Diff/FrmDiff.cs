using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Diff
{
    public partial class FrmDiff : Form
    {
        public FrmDiff()
        {
            InitializeComponent();
        }

        private void BtnDiff_Click(object sender, EventArgs e)
        {
            string message1;
            string message2;

            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\diff.txt";

            StreamReader r = new StreamReader(f);

            int count = int.Parse(r.ReadLine());
            
            for (int i=1;i<=count;i++)
            {
                message1 = r.ReadLine();
                message2 = r.ReadLine();
                
                TxtDisplay.Text += Difference(message1,message2).ToString() + Environment.NewLine;                
            }
            

            r.Close(); 
        }

        private int Difference(string m1,string m2)
        {
            int c = 0;
            int upper = 0;

            if (m1.Length <= m2.Length)
            {
                upper = m1.Length;
            }
            else
            {
                upper = m2.Length;
            }
            
            for (int i = 0; i < upper; i++)
            {
                if (m1.Substring(i, 1) == m2.Substring(i, 1))
                {
                    c++;
                }
                else
                {
                    break;
                }

            }

            return c;
        }
    }
}
