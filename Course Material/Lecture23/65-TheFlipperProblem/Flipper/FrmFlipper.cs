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

namespace Flipper
{
    public partial class FrmFlipper : Form
    {
        public FrmFlipper()
        {
            InitializeComponent();
        }

        //This problem involves a 2x2 matrix, and swapping the values of variables.
        //To solve this problem, declare a 2x2 array and set the values of the respective
        //positions according to the problem. Then, loop through all the
        //characters and perform a horizontal flip is it is 'H' and perform a vertical
        //flip otherwise.

        //A horizontal flip is simply swapping the values of the top left and bottom
        //left and also swapping the values of the top right and bottom right.A
        //vertical flip is swapping the values of the top left and top right and also
        //swapping the values of the bottom left and bottom right.

        int[,] original = new int[2, 2];

        private void BtnFlipper_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\flipper.txt";

            StreamReader r = new StreamReader(f);

            string line;
            string allflips;
            string flip;
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
                    allflips = line;

                    Initialize();
                    DisplayResults("Original List");

                    TxtDisplay.Text += "Flips " + allflips + Environment.NewLine;

                    //Extract each character V or H from the flips string
                    for (int i=0;i<allflips.Length;i++)
                    {
                        flip = allflips.Substring(i, 1);
                        if (flip=="H")
                        {
                            HorizontalFlip();
                        }
                        else if (flip=="V")
                        {
                            VerticalFlip();
                        }
                    }

                    DisplayResults("Flipped List");
                    
                }
            }
        }
        private void DisplayResults(string n)
        {
            TxtDisplay.Text += n + Environment.NewLine;
            
            for (int row = 0; row <= 1; row++)
            {
                for (int col = 0; col <= 1; col++)
                {
                    TxtDisplay.Text += original[row, col] + "\t";
                }

                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }
        
        
        private void Initialize()
        {
            original[0, 0] = 1;
            original[0, 1] = 2;
            original[1, 0] = 3;
            original[1, 1] = 4;
        }

        private void HorizontalFlip()
        {
            int temp = original[0,0];
            original[0,0] = original[1,0];
            original[1,0] = temp;

            temp = original[0,1];
            original[0,1] = original[1,1];
            original[1,1] = temp;
        }

        private void VerticalFlip()
        {
            int temp = original[0,0];
            original[0,0] = original[0,1];
            original[0,1] = temp;

            temp = original[1,0];
            original[1,0] = original[1,1];
            original[1,1] = temp;
        }
    }
}
