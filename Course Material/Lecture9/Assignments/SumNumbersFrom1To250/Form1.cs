namespace SumNumbersFrom1To250
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 1; i <= 250; i++) 
            {
                sum += i;
            }

            MessageBox.Show(sum.ToString());
        }
    }
}