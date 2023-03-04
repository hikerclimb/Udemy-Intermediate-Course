namespace MoreControls
{
    public partial class FrmMoreControls : Form
    {
        public FrmMoreControls()
        {
            InitializeComponent();
        }

        private void hzscrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            txtNumber.Text = hzscrollbar.Value.ToString();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            FrmTwo x = new FrmTwo();
            x.Show();
        }
    }
}