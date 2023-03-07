namespace SumOfSquaresBy5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSumOfSquares_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for(int i = 4; i <= 39 ; i++)
            {
                sum += Math.Pow(i, 2); 
            }

            MessageBox.Show(sum.ToString());
        }
    }
}