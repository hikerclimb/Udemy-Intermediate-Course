namespace Lectre56Assignments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDistanceBetween2Cities_Click(object sender, EventArgs e)
        {
            int[,] distanceBetweenTwoCities = new int[9, 9];
            string[] cityNames = new string[9];

            string s = Application.StartupPath;
            string f = s + @"\distancebetween2Cities.txt";
            StreamReader r = new StreamReader(f);

            string WholeLine;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    WholeLine = r.ReadLine();
                    distanceBetweenTwoCities[i, j] = Convert.ToInt32(WholeLine);
                }
            }
            for(int i = 0; i < 9; i++)
            {
                WholeLine=r.ReadLine();
                cityNames[i] = WholeLine;
            }
            PrintLine(distanceBetweenTwoCities, cityNames);

            string city = Microsoft.VisualBasic.Interaction.InputBox("Enter first city");
            string city1 = Microsoft.VisualBasic.Interaction.InputBox("Enter second city");

            int indexOfFirstCity = Match(city, cityNames);
            int indexOfSecondCity = Match(city1, cityNames);

            MessageBox.Show(distanceBetweenTwoCities[indexOfFirstCity, indexOfSecondCity].ToString());
        }

        private int Match(string city, string[] cityNames)
        {
            for(int i = 0; i < 9; i++)
            {
                if(city == cityNames[i])
                {
                    return i;
                }
            }
            return 0;
        }

        private void PrintLine(int[,] distanceBetweenTwoCities, string[] cityNames)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TxtOutput.Text += distanceBetweenTwoCities[i, j] + " ";
                }
                TxtOutput.Text += Environment.NewLine;
            }
            for (int j = 0; j < 9; j++)
            {
                TxtOutput.Text += cityNames[j] + " ";
            }
            TxtOutput.Text += Environment.NewLine;
        }


    }
}