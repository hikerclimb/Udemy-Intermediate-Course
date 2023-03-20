using System.ComponentModel.DataAnnotations;

namespace Assignment2
{
    public partial class Assignment2 : Form
    {
        public Assignment2()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"2-Diff\StudentFile\diff.txt";
                
            string[] lines = System.IO.File.ReadAllLines(f);

            int[] numOfOutput = new int[Convert.ToInt32(lines[0]) * 2];
            for (int i = 1; i < lines.Length; i += 2)
            {
                var linesFirst = lines[i];
                var linesSecond = lines[i + 1];
                for (int length = 0; length < lines[i].Length; length++)
                {
                    if (linesFirst[length] == linesSecond[length])
                    {
                        numOfOutput[i]++;
                    }
                    else
                    {
                        break;
                    }
                }
                TxtOutput.Text += numOfOutput[i] + Environment.NewLine;
            }
        }
    }
}