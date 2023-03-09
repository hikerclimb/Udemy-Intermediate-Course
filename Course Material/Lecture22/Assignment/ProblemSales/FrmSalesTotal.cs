namespace ProblemSales
{
    public partial class FrmSalesTotal : Form
    {
        public FrmSalesTotal()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            int[,] data = new int[4, 6];
            string[] names = new string[4];
            string[] daysOfWeek = new string[6];

            int rows = 4;
            int cols = 6;

            LoadData(data, rows, cols, names, daysOfWeek);
            DisplayTable(data, names, daysOfWeek, rows, cols);
        }

        private void LoadData(int[,] data, int rows, int cols, string[] names, string[] daysOfWeek)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"input.txt";

            StreamReader read = new StreamReader(f);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    data[i, j] = Convert.ToInt32(read.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                names[i] = read.ReadLine();
            }

            for (int i = 0; i < cols; i++)
            {
                daysOfWeek[i] = read.ReadLine();
            }

            read.Close();
        }

        private void DisplayTable(int[,] data, string[] names, string[] daysOfWeek, int rows, int cols)
        {
            TxtOutput.Text += "\n";
            TxtOutput.Text += "\t";
            foreach (var day in daysOfWeek)
            {
                TxtOutput.Text += day.ToString() + "\t";
            }
            TxtOutput.Text += Environment.NewLine;

            for (int i = 0; i < rows; i++)
            {
                TxtOutput.Text += names[i] + "\t";
                for (var j = 0; j < cols; j++)
                {
                    TxtOutput.Text += Convert.ToString(data[i, j]) + "\t";
                }
                TxtOutput.Text += Environment.NewLine;
            }
            TxtOutput.Text += Environment.NewLine;
        }
    }
}