using Microsoft.VisualBasic;

namespace Commission
{
    public partial class FrmCommision : Form
    {
        public FrmCommision()
        {
            InitializeComponent();
        }

        private void BtnCommision_Click(object sender, EventArgs e)
        {
            double sales;
            double percentageCommision = .14;

            sales = double.Parse(Interaction.InputBox("Enter amount of sales in a week", "Total Sales in a week", "500"));
            MessageBox.Show("Amount of commision is:" + percentageCommision * sales);
        }
    }
}