using System.Runtime.InteropServices;

namespace Selection
{
    public partial class FRmAgeHeight : Form
    {
        public FRmAgeHeight()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            DialogResult response;
            UserInput input = new UserInput();

            int c13, c14, c15, c16, c17, c18;
            int a13, a14, a15, a16, a17, a18;

            double av13, av14, av15, av16, av17, av18;

            c13 = 0;
            c14 = 0;
            c15 = 0;
            c16 = 0;
            c17 = 0;
            c18 = 0;

            av13 = 0;
            av14 = 0;
            av15 = 0;
            av16 = 0;
            av17 = 0;
            av18 = 0;

            while(true)
            {
                response = MessageBox.Show("Do you have any more entries", "Continue", MessageBoxButtons.YesNo);
                if(response == DialogResult.No) 
                {
                    break;
                }
                else
                {
                    if(input.ShowDialog() == DialogResult.OK) 
                    {
                        if(input.Age == "" && input.StudentHeight = "")
                        {
                            MessageBox.Show("Missing Age and Height", "Error", MessageBoxButtons.OK) 
                        }
                    }

                }
            }
        }
    }
}