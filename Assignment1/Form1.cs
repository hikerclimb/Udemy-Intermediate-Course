using System.Diagnostics.Metrics;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string line in System.IO.File.ReadLines(@"C:\Users\Aniket\Documents\Udemy C# Intermediate Course\Assignment1\input.txt"))
            {
                int vIndex = line.IndexOf('v');
                int iIndex = line.IndexOf('i');
                int rIndex = line.IndexOf('r');
                int uIndex = line.IndexOf('u');
                int sIndex = line.IndexOf('s');
                if(vIndex != -1 && iIndex != -1 && rIndex != -1 && uIndex != -1 && sIndex != -1)
                {
                    MessageBox.Show(line);
                }
            }

        }
    }
}