using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortByAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        PersonStructure[] output = new PersonStructure[7];
        private void BtnSortByAge_Click(object sender, EventArgs e)
        {
            PersonStructure[] data = new PersonStructure[7];

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = new PersonStructure();
                data[i].Age = 0;
                data[i].Name = "";
                data[i].Height = 0;
            }

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\nameageandheight.txt";

            StreamReader read = new StreamReader(f);
            read.ReadLine();

            for (int i = 0; i <data.Length - 1; i++) 
            {
                var readLine = read.ReadLine();
                var split = readLine.Split(" ");
                data[i].Name = split[0];
                data[i].Age = Convert.ToInt32(split[1]);
                data[i].Height = Convert.ToInt32(split[2]);
            }

            Display(ref data);
            ExchangeSortByAge(ref data);
            TxtOutput.Text += Environment.NewLine;
            Display(ref data);
        }

        private void Display(ref PersonStructure[] data)
        {
            for(int i = 0; i < data.Length - 1; i++)
            {
                TxtOutput.Text += data[i].Name + " ";
                TxtOutput.Text += data[i].Age + " ";
                TxtOutput.Text += data[i].Height + " ";
                TxtOutput.Text += Environment.NewLine;
            }
        }

        private void ExchangeSortByAge(ref PersonStructure[] data)
        {
            string tempn = "";
            int tempa = 0;
            int temph = 0;

            for (int j = 0; j <= data.Length - 1; j++)
            {
                for (int k = j + 1; k <= data.GetLength(0) -1; k++)
                {
                    if (data[j].Age < data[k].Age)
                    {
                        tempa = data[j].Age;
                        data[j].Age = data[k].Age;
                        data[k].Age = tempa;

                        temph = data[j].Height;
                        data[j].Height = data[k].Height;
                        data[k].Height = temph;

                        tempn = data[j].Name;
                        data[j].Name = data[k].Name;
                        data[k].Name = tempn;
                    }
                }
            }
        }
    }
}