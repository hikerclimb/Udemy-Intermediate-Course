using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DataAnalysis
{
    public partial class FrmDataAnalysis : Form
    {
        public FrmDataAnalysis()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnQuestionnaire_Click(object sender, EventArgs e)
        {
            int [,] VoteCount = new int [4,3];
            
            string [] Candidates = new string [4];
            string [] AgeGroups = new string [3];
            
            int [] CandidateTotal = new int[4];
                        
            int GrandTotal=0 ;

            InitializeCounters(VoteCount, CandidateTotal);
            ReadAndCount(Candidates, AgeGroups, VoteCount);
            Totals(VoteCount,CandidateTotal,ref GrandTotal);
            DisplayResults(Candidates, AgeGroups, VoteCount, CandidateTotal, GrandTotal);
            
        }

        private void InitializeCounters(int[,] V, int[] C)
        {
            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 2; c++)
                {
                    V[r, c] = 0;
                }
            }

            for (int r = 1; r <= 3; r++)
            {
                C[r] = 0;
            }
                        
        }

        private void ReadAndCount(string[] C, string[] AG, int[,] V)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\question.txt";

            StreamReader read = new StreamReader(f);

            for (int r = 1; r <= 3; r++)
            {
                C[r] = read.ReadLine();
            }

            for (int c = 1; c <= 2; c++)
            {
                AG[c] = read.ReadLine();
            }

            string line;
            int candidate, agecategory;

            while ((line = read.ReadLine()) != null)
            {
                candidate=Convert.ToInt32(line);
                agecategory=Convert.ToInt32(read.ReadLine());

                V[candidate,agecategory]=V[candidate,agecategory]+1;
            }

            read.Close();

        }

        private void Totals(int [,] V,int [] CT,ref int GT)
        {
            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 2; c++)
                {
                    CT[r] += V[r, c];                    
                }
            }

            for (int r=1;r<=3;r++)
            {
                GT+=CT[r];
            }
        }

        private void DisplayResults(string[] c, string[] ag, int[,] v, int[] ct, int g)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Questionnaire Analysis" + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;

            TxtDisplay.Text += "\t"  ;

            for (int a = 1; a <= 2; a++)
            {
                TxtDisplay.Text += ag[a] + "\t";
            }

            TxtDisplay.Text += "Total";

            TxtDisplay.Text += Environment.NewLine;

            for (int r = 1; r <= 3; r++)
            {
                TxtDisplay.Text += c[r] + "\t";
                for (int a = 1; a <= 2; a++)
                {
                    TxtDisplay.Text += Convert.ToString(v[r, a]) + "\t";
                }

                TxtDisplay.Text += ct[r];

                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += "\t" + "\t" + "\t"  + g.ToString();
        }

        private void BtnCensus_Click(object sender, EventArgs e)
        {
            int[,] CensusCount = new int[9, 3];

            string[] Ages = new string[9];
            string[] Sex = new string[3];

            int[] AgeTotals = new int[9];
            int[] SexTotals = new int[3];

            int GrandTotal = 0;

            InitializeCensusCounters(CensusCount, AgeTotals,SexTotals);
            ReadAndCountCensus(Ages, Sex, CensusCount);
            CensusTotals(CensusCount, AgeTotals,SexTotals, ref GrandTotal);
            DisplayCensusResults(Ages, Sex, CensusCount, AgeTotals, SexTotals,GrandTotal);
            
        }

        private void InitializeCensusCounters(int [,] c,int [] a,int [] s)
        {
            for (int i=1;i<=8;i++)
            {
                for (int j=1;j<=2;j++)
                {
                    c[i,j]=0;
                }
            }

            for (int i=1;i<=8;i++)
            {
                a[i]=0;
            }

            for (int j=1;j<=2;j++)
            {
                s[j]=0;
            }
        }
        
        private void ReadAndCountCensus(string [] a,string [] s,int [,] c)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\census.txt";

            StreamReader read = new StreamReader(f);

            for (int i = 1; i <= 8; i++)
            {
                a[i] = read.ReadLine();
            }

            for (int j = 1; j <= 2; j++)
            {
                s[j] = read.ReadLine();
            }

            string line;
            int age, sex;

            while ((line = read.ReadLine()) != null)
            {
                age=Convert.ToInt32(line);
                sex=Convert.ToInt32(read.ReadLine());

                c[age,sex]=c[age,sex]+1;
            }

            read.Close();
        }

        private void CensusTotals(int [,] c,int []a,int [] s,ref int g)
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    a[i] += c[i, j];
                    s[j] += c[i, j];
                }
            }

            for (int i = 1; i <= 8; i++)
            {
                g += a[i];
            }
        }

        private void DisplayCensusResults(string []a, string [] s, int [,] c, int [] at, int [] st, int g)
        {

            TxtDisplay.Clear();
            TxtDisplay.Text = "Census Analysis" + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;

            TxtDisplay.Text += "\t"  ;

            for (int i = 1; i <= 2; i++)
            {
                TxtDisplay.Text += s[i] + "\t";
            }

            TxtDisplay.Text += "Total";

            TxtDisplay.Text += Environment.NewLine;

            for (int i = 1; i <=8 ; i++)
            {
                TxtDisplay.Text += a[i] + "\t";
                for (int j = 1; j <= 2; j++)
                {
                    TxtDisplay.Text += Convert.ToString(c[i, j]) + "\t";
                }

                TxtDisplay.Text += at[i];

                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += "Total" + "\t";

            for (int j = 1; j <= 2; j++)
            {
                TxtDisplay.Text += st[j] + "\t";
            }

            TxtDisplay.Text +=  g.ToString();

        }
    }
}