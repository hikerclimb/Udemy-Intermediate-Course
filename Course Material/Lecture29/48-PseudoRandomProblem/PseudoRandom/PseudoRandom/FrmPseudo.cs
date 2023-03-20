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

namespace PseudoRandom
{
    public partial class FrmPseudo : Form
    {
        public FrmPseudo()
        {
            InitializeComponent();
        }

        string[] lines;

        //Linear Congruential Method Variables
        int Z ;
        int I ;
        int M ;
        int L ;

        //array used to track random numbers generated
        int[] Sequence;

        int cyclelength;

        private void BtnPseudo_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\pseudo.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            int RandCase = 0;

            

            bool finished = false;

            while (!finished)
            {
                WholeLine = r.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                    RandCase++;

                    //pull apart each number in the line of data and assigned it
                    //to its corresponding variable in the Pseudo Random Number formula

                    lines = WholeLine.Split(' ');

                    Z = int.Parse(lines[0]);
                    I = int.Parse(lines[1]);
                    M = int.Parse(lines[2]);
                    L = int.Parse(lines[3]);

                    //initialize size of array to M (modulus value) ... 
                    //random numbers won't go any higher than this
                    Sequence = new int[M];
                    Sequence[0] = L;        //store L (seed) as the first number of this sequence                                             

                    //Find the length of the random number cycle
                    TxtDisplay.Text += "Case " + RandCase.ToString() + ":" + FindCycle() +  Environment.NewLine;
                }

                
            }

            r.Close();
        }

        private int FindCycle()
        {
            int current = 0;

            //bool found = false;

            while(true)
            {
                Sequence[current + 1] = NextNum(current);   //here initially we have 
                                                            //Sequence[1]= NextNum(0)
                                                            //... so in the method below 
                                                            //we will have (Z * Sequence[0]+ I) % M

                //cycle through random numbers looking for duplicates
                //note if statement
                //the i cycles on the left but the right side stays constant at current+1
                for (int i=0;i< current+1;i++)
                {
                    if (Sequence[i] == Sequence[current + 1])
                    {
                        return (current + 1) - i;
                    }
                }
                current++;
            }           

        }

        private int NextNum(int c)
        {
            return (Z * Sequence[c] + I) % M; //The Linear Congruential Method formula
                                              //Remember last number generated becomes L
                                              //to refer to this number we access the 
                                              //contents of the Sequence array
        }
    }
}
