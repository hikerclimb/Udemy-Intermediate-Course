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

            /*A = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter A"));
            B = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter B"));
            C = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter C"));*/

            int number = A * C + B;

            double outp = 10.2 + .333;
            decimal outp1 = 10.2M + 1/3;

            MessageBox.Show(outp + ":" + outp1);
            
        }
    }
}