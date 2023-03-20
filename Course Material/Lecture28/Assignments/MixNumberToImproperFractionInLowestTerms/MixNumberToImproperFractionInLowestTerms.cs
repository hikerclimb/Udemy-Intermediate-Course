namespace MixNumberToImproperFractionInLowestTerms
{
    public partial class MixNumberToImproperFractionInLowestTerms : Form
    {
        public MixNumberToImproperFractionInLowestTerms()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            int A;
            int B; 
            int C;

            A = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter A"));
            B = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter B"));
            C = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter C"));

            int number = A * C + B;
            int gcdName = gcd(number, C );
            int numGcd = number / gcdName;
            int divGcd = C / gcdName;
            MessageBox.Show(number + "/" + divGcd);
            
        }

        private int gcd(int m, int n)
        {
            int temp;
            int r;

            if (m < n)
            {
                temp = m;
                m = n;
                n = temp;
            }

            while (true)
            {
                r = m % n;
                if (r == 0)
                    break;

                m = n;
                n = r;
            }

            return n;
        }

        private int lcd(int x, int y)
        {
            //the lcd of two numbers x and y is x*y/gcd(x,y)

            return x * y / gcd(x, y);
        }
    }
}