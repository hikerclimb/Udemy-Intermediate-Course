namespace Median
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMedian_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\median.txt";

            string[] array = File.ReadAllLines(f);

            Array.Sort(array);

            int median = 0;

            if (array.Length % 2 == 0 ) 
            {
                 median = (Convert.ToInt32(array[(int)(array.Length -2 )/ 2]) + Convert.ToInt32(array[(int)(array.Length)/ 2])) /2;
            }
            else if(array.Length % 2 == 1 )
            {
                median = Convert.ToInt32(array[array.Length / 2]);
            }

            MessageBox.Show(median.ToString());
        }
    }
}