namespace Problem1PartA
{
    public partial class FrmGrades : Form
    {
        public FrmGrades()
        {
            InitializeComponent();
        } 

        private void BtnPartA_Click(object sender, EventArgs e)
        {
            string[] names = new string[100];
            string[] homeRooms = new string[100];
            int[] marks = new int[100];
            int counter = 0;

            DataEntry(names, homeRooms, marks, ref counter);

        }

        private void DataEntry(string[] names, string[] homerooms, int[] marks, ref int c)
        {
            string response = "";
            while (true)
            {
                do
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you have any entries y/n", "Arrays", "", 200, 200);
                }
                while (response != "y" && response != "n");

                if (response == "n")
                    break;
                string Name = Microsoft.VisualBasic.Interaction.InputBox("Enter your name", "Arrays", "", 200, 200);
                string Homeroom = Microsoft.VisualBasic.Interaction.InputBox("Enter your name", "Arrays", "", 200, 200);
                int Mark = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter your mark", "Arrays", "", 200, 200));

                if (Mark >= 0 && Mark <=100)
                {
                    names[c] = Name;
                    homerooms[c] = Homeroom;
                    marks[c] = Mark;
                    c++;
                }
                else
                {
                    MessageBox.Show("Not a valid mark", "Error", MessageBoxButtons.OK);

                }
            }
        }
    }
}