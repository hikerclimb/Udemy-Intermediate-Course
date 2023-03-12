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
            ChangeFrankSalesFrThursTo1500(data);
            DisplayTable(data, names, daysOfWeek, rows, cols);
            CopyLucysSalesForWedIntoKarensForMonday(data);
            DisplayTable(data, names, daysOfWeek, rows, cols);
            Add10ToAllSales(data, rows, cols);
            DisplayTable(data, names, daysOfWeek, rows, cols);
            DisplayNamesOfSalespeopleAndDatesForWhichSalesBelow1000(data, rows, cols, names);
            LargestSalesAmountAndSalesPersonsNameAndDate(data, rows, cols, names, daysOfWeek);
            int[] weeklySales = WeeklySalesTotalOfEachPerson(data, rows, cols, names);
            DetermineWhoHadGreatestSales(weeklySales, names);
            WeeksPayPerPayPerson(data, rows, cols, names);


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

        private void ChangeFrankSalesFrThursTo1500(int[,] data)
        {
            data[2, 3] = 1500;
        }

        private void CopyLucysSalesForWedIntoKarensForMonday(int[,] data)
        {
            data[3, 0] = data[1, 2];
        }

        private void Add10ToAllSales(int[,] data, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    data[(int)row, (int)col] += 10;
                }
            }
        }

        private void DisplayNamesOfSalespeopleAndDatesForWhichSalesBelow1000(int[,] data, int rows, int cols, string[] names)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (data[(int)row, (int)col] < 1000)
                    {
                        TxtOutput.Text += names[row] + "\t" + data[row, col] + Environment.NewLine;
                    }
                }
            }
        }

        private void LargestSalesAmountAndSalesPersonsNameAndDate(int[,] data, int rows, int cols, string[] names, string[] dates)
        {
            int largest = 0;
            int rowPlace = 0;
            int colPlace = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (data[(int)row, (int)col] > largest)
                    {
                        largest = data[(int)row, (int)col];
                        rowPlace = row;
                        colPlace = col;
                    }
                }
            }
            TxtOutput.Text += Environment.NewLine + largest + " " + names[rowPlace] + " " + dates[colPlace] + Environment.NewLine;
        }

        private int[] WeeklySalesTotalOfEachPerson(int[,] data, int rows, int cols, string[] names)
        {
            int[] weeklySales = new int[4];

            TxtOutput.Text += Environment.NewLine;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    weeklySales[row] += data[row, col];
                }

                TxtOutput.Text += names[row] + " " + weeklySales[row] + " " + Environment.NewLine;
            }

            return weeklySales;
        }

        private void DetermineWhoHadGreatestSales(int[] weeklySales, string[] names)
        {
            int pos = weeklySales.ToList().IndexOf(weeklySales.Max());

            TxtOutput.Text += Environment.NewLine + names[pos] + Environment.NewLine;
        }

        private void WeeksPayPerPayPerson(int[,] data, int rows, int cols, string[] names)
        {
            double[] percentageCommissionPerDay = { .12, .1123, .1008, .085, .08, .0764 };
            double[] payPerPerson = new double[rows];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    payPerPerson[row] += data[row, col] * percentageCommissionPerDay[col];
                }
                TxtOutput.Text += Environment.NewLine + names[row] + ": " + payPerPerson[row] ;
            }
            TxtOutput.Text += Environment.NewLine;
        }
    }
}