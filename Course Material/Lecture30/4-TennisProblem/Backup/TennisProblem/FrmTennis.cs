using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TennisProblem
{
    public partial class FrmTennis : Form
    {
        public FrmTennis()
        {
            InitializeComponent();
        }

        double ProbAB ; 
        int PointA, PointB, GameA, GameB, SetA, SetB;
        int TotalA, TotalB;
        int n;
                

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            int TennisSimulation;

            LstDisplay.Items.Clear();

            TotalA = 0;
            TotalB = 0;

            GetProbabilities();

            for(TennisSimulation=1;TennisSimulation<=100;TennisSimulation++)
            {

                Initializations();
                Simulation();
            }
    
            if (TotalA>TotalB)
            {
                MessageBox.Show("Player A won " + TotalA.ToString() + " out of 100");
            }
            else if (TotalB > TotalA)
            {
                MessageBox.Show("Player B won " + TotalB.ToString() + " out of 100");
            }
            else
            {
                MessageBox.Show("Its a Tie");
            }


        }

        private void GetProbabilities()
        {
            do
            {
                ProbAB = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter probability of Player A beating Player B as a decimal", "Tennis", "", 200, 200));
            }
            while (ProbAB <0 || ProbAB >1);

            ProbAB = ProbAB * 100;

            while(true)
            {
                n = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter the number of sets you want to simulate MUST BE AN ODD NUMBER", "Tennis", "", 200, 200));
                if (n>0 && n%2!=0)
                    break;
            }
        }

        private void Initializations()
        {
            PointA = 0;
            PointB = 0;
            GameA = 0;
            GameB = 0;
            SetA = 0;
            SetB = 0;
        }

        private void Simulation()
        {
            string TennisString ;

            Random r = new Random();

            TennisString = "";

            while(true)
            {

                double p = r.Next(100)+1;
                
                if (p<ProbAB)
                {
                    PointA++;
                }
                else
                {
                    PointB++; 
                }
                
                if (PointA>=4 && PointA>=PointB+2)
                {
                    GameA++;
                    PointA = 0;
                    PointB = 0;
                    TennisString+= "a";
                }
                
                if( PointB >= 4 && PointB >= PointA + 2)
                {
                    GameB++;
                    PointA = 0;
                    PointB = 0;
                    TennisString += "b";
                }
                               
                if (GameA >= 6 && GameA >= GameB + 2)
                {
                    SetA++;
                    GameA = 0;
                    GameB = 0;
                    TennisString+= "*A*";
                }
                                
                if (GameB >= 6 && GameB >= GameA + 2)
                {
                    SetB++;
                    GameA = 0;
                    GameB = 0;
                    TennisString +="*B*";
                }
                                
                if (SetA + SetB == n)
                    break;

            }

            if (SetA > SetB)
            {
                TennisString += "  -->Player A wins " + SetA.ToString() + "/" + n.ToString();
                TotalA++;
            }
            else
            {
                TennisString+= "  -->Player B wins " + SetB.ToString()+  "/" + n.ToString();
                TotalB ++;
            }

            
            LstDisplay.Items.Add(TennisString);

        }

    }
}