namespace FirstApp
{
    public partial class FrmFirstApp : Form
    {
        public FrmFirstApp()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + txtName.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoHappy_CheckedChanged(object sender, EventArgs e)
        {
            picHappy.Visible = true;
            picSad.Visible = false;
        }

        private void rdoSad_CheckedChanged(object sender, EventArgs e)
        {
            picHappy.Visible = false;
            picSad.Visible = true;
        }
    }
}