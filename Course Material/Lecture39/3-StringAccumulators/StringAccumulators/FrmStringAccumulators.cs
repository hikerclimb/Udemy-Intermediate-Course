using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StringAccumulators
{
    public partial class FrmStringAccumulators : Form
    {
        public FrmStringAccumulators()
        {
            InitializeComponent();
        }

        private void BtnConcat_Click(object sender, EventArgs e)
        {
            string word;
            string reverse = "";

            word = Microsoft.VisualBasic.Interaction.InputBox("Enter a Word", "String Accumulators", "", 200, 200);

            for (int i = word.Length-1; i >=0; i--)
            {
                reverse = reverse + word.Substring(i, 1);
            }

            MessageBox.Show("Word Reversed is " + reverse);

        }

        private void BtnApplication_Click(object sender, EventArgs e)
        {
            string number;
            string reverse="";

            number = Microsoft.VisualBasic.Interaction.InputBox("Enter a number ", "Application of Strings", "", 200, 200);

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reverse += number.Substring(i, 1);
            }

            long total = int.Parse(number) + int.Parse(reverse);

            TxtResult.Text = number + Environment.NewLine + reverse + Environment.NewLine + total.ToString();
                        
        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {
            string number1;
            string number2;

            number1 = Microsoft.VisualBasic.Interaction.InputBox("Enter a number ", "Application of Strings", "", 200, 200);
            number2 = Microsoft.VisualBasic.Interaction.InputBox("Enter a number ", "Application of Strings", "", 200, 200);

            string number12nd = number1.Substring(1, 1);
            string number14th  = number1.Substring(3, 1);
            string number16th = number1.Substring(5, 1);

            string number22nd = number2.Substring(1, 1);
            string number24th = number2.Substring(3, 1);
            string number26th = number2.Substring(5, 1);

            string one = number12nd + number14th + number16th;
            string second = number22nd + number24th + number26th;

            int sum = Convert.ToInt32(one) + Convert.ToInt32(second);
            MessageBox.Show(sum.ToString());
        }
    }
}