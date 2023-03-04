using Microsoft.VisualBasic;

namespace Volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculateVolume_Click(object sender, EventArgs e)
        {
            int len;
            int wid;
            int hei;
            int vo;

            len = int.Parse(Interaction.InputBox("Please enter length", "Length", "10"));
            wid = int.Parse(Interaction.InputBox("Please enter lengt", "Width", "10"));
            hei = int.Parse(Interaction.InputBox("Please enter length", "Height", "10"));

            MessageBox.Show((len * wid * hei).ToString());
        }
    }
}