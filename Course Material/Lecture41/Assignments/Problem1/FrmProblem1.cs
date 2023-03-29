using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem1
{
    public partial class FrmProblem1 : Form
    {
        public FrmProblem1()
        {
            InitializeComponent();
        }

        private void BtnCheckDigit_Click(object sender, EventArgs e)
        {
            string AccountNumber;
            do
            {
                AccountNumber = Microsoft.VisualBasic.Interaction.InputBox("enter credit card number", "Credit Validation", "", 200, 200);
            }
            while (AccountNumber.Length != 10);
            int total = 0;
            for(int i = 1; i <= 9; i++) 
            {
                total += Convert.ToInt32(AccountNumber[i].ToString()) *2;
            }
            if (Convert.ToInt32(AccountNumber[0].ToString()) == total )
            {
                MessageBox.Show("Valid");
            }
            else
            {
                MessageBox.Show("InValid");
            }
        }
    }
}