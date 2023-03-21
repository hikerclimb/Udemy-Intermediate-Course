namespace Casino
{
    public partial class FrmRoulette : Form
    {
        public FrmRoulette()
        {
            InitializeComponent();
        }

        private void BtnSpin_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double GameWinsLosses = 0.0;
            int nPicked = 0;
            int[] sameNumber = new int[36];
            decimal moneySpentThisSim = 0;
            string GameString = String.Empty;

            for (int simulation = 0; simulation < 200; simulation++)
            {
                for (int h = 0; h < 36; h++)
                {
                    sameNumber[h] = 0;
                }
                GameWinsLosses = GameWinsLosses - 7.5;
                while(true)
                {
                    nPicked = r.Next(0, 36);

                    if (sameNumber[nPicked] == 1)
                    { break; }

                    sameNumber[nPicked] = 1;
                    GameWinsLosses++;
                }
            }
            TxtBoxOutput.Text += "money spent: " + GameWinsLosses;
        }
    }
}