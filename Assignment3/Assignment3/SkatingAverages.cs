using System.Globalization;
using System.Xml.Linq;

namespace Assignment3
{
    public partial class SkatingAverages : Form
    {
        public SkatingAverages()
        {
            InitializeComponent();
        }

        private void TxtProcess_Click(object sender, EventArgs e)
        {
            var StartUpPath = Application.StartupPath;
            var f = StartUpPath + @"skating.txt";

            string[] lines = System.IO.File.ReadAllLines(f);
            var numberOfIterations = Convert.ToInt32(lines[0]);

            string[] skatingScores = new string[12];
            double skatingScoresTotal = 0.0;
            string name = "";
            for (int numberOfIteration = 0; numberOfIteration < numberOfIterations; numberOfIteration++)
            {
                for (int line = 0; line < 12; line++)
                {
                    skatingScores[line] = lines[(line + (numberOfIteration * 13) + 2)];
                }
                RemoveLargestValue(skatingScores);
                RemoveSmallestValue(skatingScores);
                foreach (var item in skatingScores)
                {
                    if (item != "-1.0")
                    {
                        skatingScoresTotal += Convert.ToDouble(item);
                    }
                }
                double average = skatingScoresTotal / 10.0;

                TxtOutput.Text += name + average.ToString() + Environment.NewLine;
            }
        }

        string[] RemoveLargestValue(string[] scores)
        {
            double largestValue = -1.0;
            int index = 0;
            for (int i =0; i < scores.Length; i++)
            {
                if (Convert.ToDouble(scores[i]) > largestValue)
                {
                    largestValue = Convert.ToDouble(scores[i]);
                    index = i;
                }
            }

            scores[index] = "-1.0";

            return scores;
        }

        string[] RemoveSmallestValue(string[] scores)
        {
            double smallestValue = 100;
            int index = 0;
            foreach (var score in scores)
            {
                if (Convert.ToDouble(score) > smallestValue)
                {
                    smallestValue = Convert.ToDouble(score);
                    index = score.IndexOf(smallestValue.ToString());
                }
            }

            scores[index] = "-1.0";
            return scores;
        }
    }
}