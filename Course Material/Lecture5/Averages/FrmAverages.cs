using Microsoft.VisualBasic;

namespace Averages
{
    public partial class FrmAverages : Form
    {
        public FrmAverages()
        {
            InitializeComponent();
        }

        private void BtnAverages_Click(object sender, EventArgs e)
        {
            int mark1;
            int mark2;
            int mark3;
            double average = 0;

            mark1 = int.Parse(Interaction.InputBox("Please enter a mark.", "Average", "50"));
            mark2 = int.Parse(Interaction.InputBox("Please enter a mark.", "Average", "50"));
            mark3 = int.Parse(Interaction.InputBox("Please enter a mark.", "Average", "50"));

            average = (double)(mark1 + mark2 + mark3) / 3;

            MessageBox.Show("the average is " + average.ToString());
        }
    }
}