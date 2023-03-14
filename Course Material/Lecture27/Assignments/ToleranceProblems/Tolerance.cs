namespace ToleranceProblems
{
    public partial class Tolerance : Form
    {
        public Tolerance()
        {
            InitializeComponent();
        }

        private void BtnProblem1_Click(object sender, EventArgs e)
        {

            TxtOutput.Clear();
            for (int x = -10; x <= 10; x++)
            {
                TxtOutput.Text += x.ToString() + "\t";
                decimal dem = Convert.ToDecimal(Math.Pow(x, 2) - 7 * x + 12);
                decimal num = Convert.ToDecimal(Math.Pow(x, 3) - 4 * Math.Pow(x, 2));
                TxtOutput.Text += num.ToString() + Environment.NewLine;
                if (dem == 0)
                {
                    TxtOutput.Text += "can't divide by 0" + Environment.NewLine;
                }
                else
                {
                    decimal y = Convert.ToDecimal(num / dem);
                    TxtOutput.Text += y.ToString() + Environment.NewLine;
                }
            }
        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {

            TxtOutput.Clear();
            double a = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("enter a value0", "Tolerance", "", 200, 200));
            double b = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("enter a value0", "Tolerance", "", 200, 200));
            double c = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("enter a value0", "Tolerance", "", 200, 200));

            if (Math.Abs(Convert.ToDecimal(Math.Pow(a, 2))) + Convert.ToDecimal(Convert.ToDecimal(Math.Pow(b, 2))) == Convert.ToDecimal(Convert.ToDecimal(Math.Pow(c, 2))))
            {
                MessageBox.Show("This is a right angled triangle.");
            }
            else
            {
                MessageBox.Show("This is not a right angled triangle.");
            }
        }

        private void BtnProblem3_Click(object sender, EventArgs e)
        {

            TxtOutput.Clear();
            double x1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("enter a x1", "x1", "", 200, 200));
            double x2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("enter a x2", "x2", "", 200, 200));
            double x3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("enter a x3", "x3", "", 200, 200));

            double y1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("enter a y1", "y1", "", 200, 200));
            double y2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("enter a y2", "y2", "", 200, 200));
            double y3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("enter a y3", "y3", "", 200, 200));

            if (Math.Abs((Convert.ToDecimal(x2) - Convert.ToDecimal(x1)) * (Convert.ToDecimal(y3) - Convert.ToDecimal(y1))) == (Convert.ToDecimal(x3) - Convert.ToDecimal(x1)) * (Convert.ToDecimal(y2) - Convert.ToDecimal(y1)))
            {
                MessageBox.Show("The three points are collinear");
            }
            else
            {

                MessageBox.Show("The three points are not collinear");
            }
        }

        private void BtnProblem4_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();

            double squareroot1;
            int squareroot2;
            for (int i = 0; i < 1000; i++)
            {
                squareroot1 = Math.Sqrt(i);
                squareroot2 = (int)Math.Sqrt(i);

                if (Math.Abs(Convert.ToDecimal(squareroot1) - Convert.ToDecimal(squareroot2)) == 0)
                {
                    TxtOutput.Text += i.ToString() + " is a perfect square" + Environment.NewLine;
                }
            }
        }
    }
}