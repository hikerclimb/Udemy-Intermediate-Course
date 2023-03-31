namespace Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Square(2).ToString());
        }
        
        private int Square(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Square(n -1) +(2*n) -1 ;
            }
        }
    }
}