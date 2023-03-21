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
            decimal totalMoneyMade = 0;
            for (int i = 0; i < 1000; i++)
            {
                decimal cost =+ .25m;
                totalMoneyMade =+ .25m;
                int brea = 0;
                Random r = new Random();
                int hitPlates = 0;
                for (int j = 0; j < 3; j++)
                {
                    brea = r.Next(1, 8);
                    if (brea < 4)
                    {
                        hitPlates++;
                        cost -= .04m;
                        totalMoneyMade -= .04m;
                    }
                    else if (brea == 2) { }
                    {

                    }
                    if (hitPlates == 3)
                    {
                        cost -= 1;
                        totalMoneyMade -= 1;
                    }
                }
                TxtBoxCost.Text += ((cost).ToString()) + Environment.NewLine;
            }
            MessageBox.Show("total money made: " + totalMoneyMade.ToString());
        }
    }
}