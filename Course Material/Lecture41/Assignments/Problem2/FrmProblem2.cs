namespace Problem2
{
    public partial class FrmProblem2 : Form
    {
        public FrmProblem2()
        {
            InitializeComponent();
        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {
            string BarCode;
            do
            {
                BarCode = Microsoft.VisualBasic.Interaction.InputBox("enter credit card number", "Credit Validation", "", 200, 200);
            }
            while (BarCode.Length != 5);

            int total = 0;
            int j = 0;
            for(int i = 5; i >=2; i--)
            {
                total += Convert.ToInt32(BarCode[j].ToString())*i;
                j++;
            }
            int rem = total % 11;
            int answer = 11 - rem;
            if(answer == BarCode[4]) {
                MessageBox.Show("valid");
            }

            
        }
    }
}