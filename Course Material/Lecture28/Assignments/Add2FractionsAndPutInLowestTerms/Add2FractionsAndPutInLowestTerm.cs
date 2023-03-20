using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add2FractionsAndPutInLowestTerms
{
    public partial class Add2FractionsAndPutInLowestTerm : Form
    {
        public Add2FractionsAndPutInLowestTerm()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            int A;
            int B;
            int C;
            int D;

            A = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter A"));
            B = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter B"));
            C = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter C"));
            D = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter D"));

            int firstnumerator = D * A;
            int secondnumerator = C*B;
            int denominator = B * D;

            int numeratorOf2 = firstnumerator + secondnumerator;

            int gcdOut = gcd(numeratorOf2, denominator);

            int denominatorOut = denominator / gcdOut;
            int numeratorOut = numeratorOf2 / gcdOut;

            MessageBox.Show(numeratorOut + "/" + denominatorOut);
        }

        private int gcd(int m, int n)
        {
            int temp;
            int r;

            if (m < n)
            {
                temp = m;
                m = n;
                n = temp;
            }

            while (true)
            {
                r = m % n;
                if (r == 0)
                    break;

                m = n;
                n = r;
            }

            return n;
        }

        private int lcd(int x, int y)
        {
            //the lcd of two numbers x and y is x*y/gcd(x,y)

            return x * y / gcd(x, y);
        }
    }
}
