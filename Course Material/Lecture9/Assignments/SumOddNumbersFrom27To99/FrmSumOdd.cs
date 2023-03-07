namespace SumOddNumbersFrom27To99
{
    public partial class FrmSumOdd : Form
    {
        public FrmSumOdd()
        {
            InitializeComponent();
        }

        private void BtnSumOdd_Click(object sender, EventArgs e)
        {
            int sumOdd = 0;
            for(int i = 27; i <= 99; i++)
            {
                if(i %2 == 1)
                {
                    sumOdd += i;
                }
            }
            MessageBox.Show(sumOdd.ToString());
        }
    }
}