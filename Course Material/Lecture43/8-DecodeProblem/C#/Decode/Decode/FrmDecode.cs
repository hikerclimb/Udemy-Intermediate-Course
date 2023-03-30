using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Decode
{
    public partial class FrmDecode : Form
    {
        public FrmDecode()
        {
            InitializeComponent();
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\decode.txt";

            StreamReader r = new StreamReader(f);

            string code;
            bool finished = false;

            while (!finished)
            {
                code = r.ReadLine();
                if (code == null)
                {
                    finished = true;
                }
                else
                {
                    TxtDisplay.Text += Decode(code) + Environment.NewLine;                    
                }
            }
            r.Close();
        }

        private string Decode(string c)
        {
            string d = "";
            int rows = c.Length / 5;

            for (int r = 0; r < rows; r++)
            {
                int cols = r;
                while (cols < c.Length)
                {
                    string ch = c.Substring(cols, 1);
                    
                    if (ch == "*")
                        ch = " ";

                    d = d + ch;
                    cols += rows;
                }
            }

            return d;
        }
    }
}
