namespace Storage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declaration of variables section
        int age;
        string yourname;
        double pay;

        private void BtnGo_Click(object sender, EventArgs e)
        {
            //assignment statements
            age = 15;
            yourname = "Aniket";
            pay = 130.75;

            //display the results ... output
            MessageBox.Show("your age is " + age.ToString());
            MessageBox.Show("your name is " + yourname);
            MessageBox.Show("your pay is " + pay.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your name is " + yourname);
        }
    }
}