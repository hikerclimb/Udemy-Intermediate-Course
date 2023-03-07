using System.Drawing;
using System.Globalization;

namespace MethodAssignment
{
    public partial class FrmProblems : Form
    {
        public FrmProblems()
        {
            InitializeComponent();
        }

        private void BtnProblem1_Click(object sender, EventArgs e)
        {
            double len;
            double wd;
            double height;

            len = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("enter the length", "Volume", "", 200, 200));
            wd = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("enter the width", "Volume", "", 200, 200));
            height = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("enter the height", "Volume", "", 200, 200));

            double vol = Volume(len, wd, height);

            MessageBox.Show("the volume is: " + vol);
        }

        private double Volume(double x, double y, double z)
        {
            double v;
            v = x * y * z;
            return v;
        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("enter a number", "Odd or Even", "", 200, 200));
            if (number % 2 == 0)
            {
                MessageBox.Show("even");
            }
            else
            {
                MessageBox.Show("odd");
            }
        }

        private void BtnProblem3_Click(object sender, EventArgs e)
        {
            int FirstNumber = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("enter a number", "FirstNumber", "", 200, 200));
            int SecondNumber = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("enter a number", "SecondNumber", "", 200, 200));
            while (true)
            {
                if (FirstNumber > SecondNumber)
                {
                    continue;
                }
                else
                {
                    FirstNumber = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please reenter first number", "FirstNumber", "", 200, 200));
                    break;
                }
            }

            MessageBox.Show((SecondNumber - FirstNumber).ToString());
        }

        private void BtnProblem4_Click(object sender, EventArgs e)
        {
            double Number = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter number to find cube root", "Cube Root", "", 200, 200));
            double outp = Math.Pow((double)Number, (double)1 / 3);
            MessageBox.Show(Convert.ToString(outp));
        }

        private void BtnProblem5_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter weight of package", "Package", "", 200, 200));
            double cost = 0;
            if(weight <8) {
                cost += .32;
                MessageBox.Show(cost.ToString());
            }
            else if (weight > 8 && weight <= 12)
            {
                cost += .47;
                MessageBox.Show(cost.ToString());
            }
            else if (weight > 12 && weight <= 16)
            {
                cost += .62;
                MessageBox.Show(cost.ToString());
            }
            else if (weight > 16 && weight <= 20)
            {
                cost += .77;
                MessageBox.Show(cost.ToString());
            }
            else if (weight > 20 && weight <= 24)
            {
                cost += .92;
                MessageBox.Show(cost.ToString());
            }
            else
            {
                MessageBox.Show("too heavy");
            }
        }
    }
}