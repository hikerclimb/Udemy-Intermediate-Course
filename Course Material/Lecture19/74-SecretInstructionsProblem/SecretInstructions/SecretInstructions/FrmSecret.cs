using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SecretInstructions
{
    public partial class FrmSecret : Form
    {
        public FrmSecret()
        {
            InitializeComponent();
        }

        
        string[] Secret = new string[100];
        string[] DecodedDirection = new string[100];
        int counter = 0;

        private void BtnSecret_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\secret.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            while (!finished)
            {
                line = r.ReadLine();              

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    counter++;
                    Secret[counter] = line;                    
                }

            }

            r.Close();

            DecipherSecrets(Secret, counter);
        }

        private void DecipherSecrets( string [] S, int c)
        {
            TxtDisplay.Text = "";
            string FirstTwo;
            string LastThree;
            int Sum;

            for (int i=1;i<=c;i++)
            {
                FirstTwo = S[i].Substring(0, 2); //This starts at the 1st letter and takes 2
                LastThree = S[i].Substring(2);   //This starts at 3rd letter and takes the rest

                //Find sum of the first two numbers
                Sum = 0;
                for (int j = 0; j <= 1; j++)
                {
                    Sum += int.Parse(FirstTwo.Substring(j, 1));
                }   

                //Decide on direction based on even or odd sum or zero
                if (Sum %2 ==1)
                {
                    DecodedDirection[i] = "Left ";
                }
                else if (Sum%2==0 && int.Parse(FirstTwo)==0)
                {
                    DecodedDirection[i] = DecodedDirection[i - 1]; //take the previous direction answer
                }
                else if (Sum%2==0)
                {
                    DecodedDirection[i] = "Right ";
                }

                TxtDisplay.Text += DecodedDirection[i] + " " + LastThree + Environment.NewLine;                                       

            }

           
        }
    }
}
