namespace ShootingGallery
{
    public partial class ShootingGallery : Form
    {
        public ShootingGallery()
        {
            InitializeComponent();
        }

        private void BtnCalculateAvg_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                decimal cost =+ .25m;
                int brea = 0;
                Random r = new Random();
                int hitPlates = 0;
                for (int j = 0; j < 3; j++)
                {
                    brea = r.Next(1, 3);
                    if (brea == 1)
                    {
                        hitPlates++;
                        cost += .04m;
                    }
                    else if (brea == 2) { }
                    {

                    }
                    if (hitPlates == 3)
                    {
                        cost -= 1;
                    }
                }
                TxtBoxCost.Text += ((cost).ToString()) + Environment.NewLine;
            }
        }
    }
}