using System.Drawing.Text;

namespace ArmstrongNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnArmstrongNumbers_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 500; i++)
            {
                ArmstrongNumbers(i);
            }
        }

        private void ArmstrongNumbers(int num)
        {
            int otu = 0;
            int castBackToNumber = 0;
            foreach (var item in num.ToString())
            {
                castBackToNumber = (int)Char.GetNumericValue(item);
                otu += (int)Math.Pow(castBackToNumber, 3);
                if (num == otu)
                    TxtOutpt.Text += num + Environment.NewLine;
            }
        }

        private void ArmstrongNumberUsingMath()
        {
            int remainder = 0;

        }
    }
}