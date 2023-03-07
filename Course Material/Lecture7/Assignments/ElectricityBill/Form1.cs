using Microsoft.VisualBasic;

namespace ElectricityBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnElectricity_Click(object sender, EventArgs e)
        {
            int kilowatHours = 0;
            double cost = 0;
            kilowatHours = int.Parse(Interaction.InputBox("Enter kilowatts", "Kilowatts", "10"));

            if(kilowatHours <= 12)
            {
                cost = 2.80;
            }
            else if(kilowatHours > 12 && kilowatHours <= 90) 
            {
                cost = (kilowatHours - 12) * .08 + 2.80;
            }
            else if (kilowatHours >= 90)
            {
                cost = (78 * .08) + (kilowatHours - 90) * .06 + 2.80;
            }

            MessageBox.Show("Elecricity Bill:" + cost.ToString("c"));
        }
    }
}