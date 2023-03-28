namespace ArmstrongNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnArmstrongNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 500; i++)
            {
                for(int j = 0; j <= 9; j++) { }
                var otu = i*i*i;
                if(i == otu)
                {
                    TxtOutpt.Text += "i == out" + i +": " +otu;
                }
            }
        }
    }
}