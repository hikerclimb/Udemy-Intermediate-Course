using System.Security.Policy;

namespace Lecture45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void BtnProblem1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (FibonacciSequenceRecursively(i) > 1)
                {
                    break;
                }
                TxtOutput.Text += FibonacciSequenceRecursively(i) + " ";
                i++;
            }
        }
        private void FibonaciSequenceNonRecursive(int n)
        {
            int prev = 0;
            int current = 1;
            int nextNumber = 0;
            TxtOutput.Text += prev + " " + current + " ";
            for (int i = 0; i <= n; i++)
            {
                nextNumber = prev + current;
                prev = current;
                current = nextNumber;
                TxtOutput.Text += nextNumber + " ";
                if (nextNumber >= n)
                {
                    break;
                }
            }
        }

        private int FibonacciSequenceRecursively(int n)
        {
            if(n == 0) return 0;
            if(n == 1) return 1;
            return FibonacciSequenceRecursively(n-1) + FibonacciSequenceRecursively(n-2);
            
        }
    }
}