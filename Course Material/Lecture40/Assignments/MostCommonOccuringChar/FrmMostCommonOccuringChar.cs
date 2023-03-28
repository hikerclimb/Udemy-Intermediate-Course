namespace MostCommonOccuringChar
{
    public partial class FrmMostCommonOccuringChar : Form
    {
        public FrmMostCommonOccuringChar()
        {
            InitializeComponent();
        }

        private void BtnCommonChar_Click(object sender, EventArgs e)
        {
            string message = "";
            message = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            int[] numberOfCharacters = new int[256];
            foreach(var item in message)
            {
                numberOfCharacters[(int)item]++;
            }
            
            var output = numberOfCharacters.Max();

            var max = maximumCharacter(message.ToCharArray(), message.Length);

            MessageBox.Show(max + ": "  + output);

        }
        private char maximumCharacter(char[] message, int n)
        {
            char max = 'A';

            for(int i =0; i < n; i++)
            {
                if (message[i] > max)
                {
                    max = message[i];
                }
            }
            return max;
        }

    }
}