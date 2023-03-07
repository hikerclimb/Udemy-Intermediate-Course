namespace Repetition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                txtBxOutput.Text += i + "steamboat" + "\r\n";
            }
            txtBxOutput.Text += "CHARGE !";

        }
    }
}