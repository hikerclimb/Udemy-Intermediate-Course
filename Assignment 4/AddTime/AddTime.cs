namespace AddTime
{
    public partial class AddTime : Form
    {
        public AddTime()
        {
            InitializeComponent();
        }

        private void SumTime_Click(object sender, EventArgs e)
        {
            var StartUpPath = Application.StartupPath;
            var f = StartUpPath + @"times.txt";

            string[] lines = System.IO.File.ReadAllLines(f);

            var numberOFTimesToAdd = Convert.ToInt32(lines[0]);

            int[] minuteOut = new int[numberOFTimesToAdd * 2];
            int[] hourOut = new int[numberOFTimesToAdd * 2];
            int[] dayOut = new int[numberOFTimesToAdd * 2];


            int[] day = new int[numberOFTimesToAdd * 2];
            int[] hour = new int[numberOFTimesToAdd * 2];
            int[] min = new int[numberOFTimesToAdd * 2];

            for (int i = 0; i < day.Length; i++)
            {
                day[i] = Convert.ToInt32(lines[(i * 3) + 1]);
                hour[i] = Convert.ToInt32(lines[(i * 3) + 2]);
                min[i] = Convert.ToInt32(lines[(i * 3) + 3]);
            }

            for (int i = 0; i < hour.Length - 1; i = i + 2)
            {
                dayOut[i] = day[i] + day[i + 1];
                if ((hour[i] + hour[i + 1]) / 24 >= 1)
                {
                    hourOut[i] = hour[i] + hour[i + 1] - 24;
                    dayOut[i]++;
                }
                else
                {
                    hourOut[i] = hour[i] + hour[i + 1];
                }
                if ((min[i] + min[i + 1]) / 60 >= 1)
                {
                    minuteOut[i] = min[i] + min[i + 1] - 60;
                    hourOut[i]++;
                }
                else
                {
                    minuteOut[i] = min[i] + min[i + 1];
                }
                TxtOutput.Text += dayOut[i] + "days " + hourOut[i] + "hours " + minuteOut[i] + "minutes " + Environment.NewLine;
            }

        }
    }
}