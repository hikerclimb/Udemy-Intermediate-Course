using Microsoft.VisualBasic;

namespace BroadloomCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBroadloomCost_Click(object sender, EventArgs e)
        {
            int broadloom = 12;
            int length;
            int width;

            length = int.Parse(Interaction.InputBox("What is length of broadloom?", "Length of Broodloom", "10"));
            width = int.Parse(Interaction.InputBox("What is width of broadloom?", "Width of Broodloom", "10"));
            broadloom = length * width;

            MessageBox.Show("The cost of broadloom is:$" + broadloom);
        }
    }
}