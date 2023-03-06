using Microsoft.VisualBasic;

namespace PercentageMarkup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPercentageMarkup_Click(object sender, EventArgs e)
        {
            int sellingPrice;
            int cost;
            int markup;

            sellingPrice = int.Parse(Interaction.InputBox("What is selling price?", "Selling Price", "100"));
            cost = int.Parse(Interaction.InputBox("What is cost for item?", "Cost", "50"));

            markup = ((sellingPrice - cost) / (cost)) * 100;
            MessageBox.Show("The percentage markups is: " + markup + "%");
        }
    }
}