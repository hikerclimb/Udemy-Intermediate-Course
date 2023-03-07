using Microsoft.VisualBasic;

namespace Averages
{
    public partial class FrmAverages : Form
    {
        public FrmAverages()
        {
            InitializeComponent();
        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {
            int firstScore;
            int secondScore;
            int thirdScore;
            int fourthScore;

            firstScore = int.Parse(Interaction.InputBox("enter first score"));
            secondScore = int.Parse(Interaction.InputBox("enter second score"));
            thirdScore = int.Parse(Interaction.InputBox("enter third score"));
            fourthScore = int.Parse(Interaction.InputBox("enter fourth score"));

            double average = (double)(firstScore + secondScore + thirdScore + fourthScore)/ 4;
            if (average >= 70)
            {
                MessageBox.Show("You have a passing grade");
            }
            else
            {
                MessageBox.Show("You have a failing grade");
            }
        }
    }
}