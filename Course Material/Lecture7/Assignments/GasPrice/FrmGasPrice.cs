using Microsoft.VisualBasic;

namespace GasPrice
{
    public partial class FrmGasPrice : Form
    {
        public FrmGasPrice()
        {
            InitializeComponent();
        }

        private void BtnGas_Click(object sender, EventArgs e)
        {
            int gas;
            double bill = 0;

            gas = int.Parse(Interaction.InputBox("Please enter gas usage in ccf", "Gas Bill", ""));

            if (gas <= 8) 
            {
                bill = gas * .50;
            }
            else if(gas > 8)
            {
                bill = 8 * .50 + (gas - 8) * .30;
            }

            MessageBox.Show("your gas bill is " + bill.ToString("c"));
        }
    }
}