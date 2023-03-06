using Microsoft.VisualBasic;

namespace CustomersBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCustomersBill_Click(object sender, EventArgs e)
        {
            int PoundsPurchased;
            int PricePerPound;
            int CustomersBill;

            PoundsPurchased = Convert.ToInt32(Interaction.InputBox("Enter number of Pounds Purchased", "Pounds Purhased", "4" ));
            PricePerPound = Convert.ToInt32(Interaction.InputBox("Enter Price Per Pound", "Price Per Pound", "4"));
            CustomersBill = PoundsPurchased * PricePerPound;
            MessageBox.Show("Customers Bill:" + CustomersBill);
        } 
    }
}