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

namespace StrFry
{
    public partial class FrmStrFry : Form
    {
        public FrmStrFry()
        {
            InitializeComponent();
        }

        string[] lines;

        private void BtnStrFry_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Scrambled Word Check Results" + Environment.NewLine + Environment.NewLine;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\words.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            int n = 0;

            n = int.Parse(r.ReadLine());
                      
            for (int i=1;i<=n;i++)
            {
                WholeLine = r.ReadLine();
                lines = WholeLine.Split(' ');

                //Here we pass the array 'lines' which contains the split apart text (the two scrambled words)
                if (CouldBe(lines))
                {
                    TxtDisplay.Text += "Properly Fried" + Environment.NewLine;
                }
                else
                {
                    TxtDisplay.Text += "Puzzle Overcooked" + Environment.NewLine;
                }

            }               

            

            r.Close();
        }

        private bool CouldBe(string [] ws)
        {
            bool status = false;

            //The ToCharArray method of the string class converts a string to a character array.
            char[] c1 = ws[0].ToCharArray();
            char[] c2 = ws[1].ToCharArray();

            if (c1.Length != c2.Length)
                return status;

            Array.Sort(c1);
            Array.Sort(c2);

            //First tried Array.Equals(c1,c2)
            //But there is no static equals method in the Array class
            //so what you are using is actually Object.Equasl, which determines
            //if the two object references point to the same object

            //If you want to check if the arrays contain the same items in the 
            //same order, you can use the SequenceEquals extension method
            status = c1.SequenceEqual(c2);

            return status;
        }
    }
}
