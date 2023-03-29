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
                int num1 = 0;
                int num2 = 0;
                int num3 = 0;
                int num3rem = 0;
                if (i.ToString().Length == 1)
                {
                    num1 = i;
                }
                if (i.ToString().Length == 2 )
                {
                    num2 = i % 10;
                    num1 = (int)Math.Floor(i / 10.0);
                }
                if (i.ToString().Length == 3)
                {
                    num3 = i % 10;
                    num3rem = i / 10;
                    num2 = (num3rem) %10;
                    num1 = i / 100;
                }

                var otu = num1 * num1 * num1 + num2 * num2 * num2 + num3 * num3 * num3;
                if(i == otu)
                {
                    TxtOutpt.Text += "i == out" + i +": " +otu + Environment.NewLine;
                }
            }
        }

       
    }
}