using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TriangleProblem
{
    public partial class FrmTriangleProblem : Form
    {
        public FrmTriangleProblem()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int lower = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter the lower limit", "Triangle Numbers", "", 200, 200));
            int upper = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter the upper limit", "Triangle Numbers", "", 200, 200));

            for (int i = lower; i <= upper; i++)
            {
                LstTriangles.Items.Add(i.ToString() + "\t" + Triangles(i).ToString());
            }

        }

        private long Triangles(long number)
        {
            // base case                               
            if (number == 1)
            {
                return 1;
            }
            // recursion step                          
            else
            {
                return number + Triangles(number - 1);
            }
        }
    }
}