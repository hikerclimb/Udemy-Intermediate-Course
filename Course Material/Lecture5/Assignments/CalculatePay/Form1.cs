using Microsoft.VisualBasic;

namespace CalculatePay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculatePay_Click(object sender, EventArgs e)
        {
            string name;
            int rateOfPay;
            int hoursWorked;

            name = Interaction.InputBox("Please enter name", "Name");
            rateOfPay = int.Parse(Interaction.InputBox("Please enter rate of pay", "Rate Of Pay"));
            hoursWorked = int.Parse(Interaction.InputBox("Pleae enter number of hours worked", "Number of Hours Worked"));

            MessageBox.Show("Gross Pay: $" + rateOfPay * hoursWorked);
            MessageBox.Show("Taxes: $" + (rateOfPay * hoursWorked)* .20);
            MessageBox.Show("Net Pay: $" + ((rateOfPay * hoursWorked) - ((rateOfPay * hoursWorked) * .20)));
        }
    }
}