using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SkatingScoring
{
    public partial class FrmSkatingScoring : Form
    {
        public FrmSkatingScoring()
        {
            InitializeComponent();
        }

        private void BtnScores_Click(object sender, EventArgs e)
        {

            string skatername;
            
            double max;
            double min;
            double score;
            double sum;            
            double finalscore;
            
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\skating.txt";

            StreamReader r = new StreamReader(f);

            //read in number of scores to be processed
            int numTimes = int.Parse(r.ReadLine());

            TxtDisplay.Text = "Final Results" + Environment.NewLine;
            
            for (int skater = 1; skater <= numTimes; skater++)
            {

                sum = 0;
                max = -1;
                min = 100;

                skatername = r.ReadLine();

                for (int s = 1; s <= 12; s++)
                {
                    score=double.Parse(r.ReadLine());
                    
                    if (score > max)
                    {
                        max=score;
                    }
                    if (score < min)
                    {
                        min=score;
                    }

                    sum+=score;
                    
                }
                
                finalscore = (sum-max-min)/10.0;

                TxtDisplay.Text += skatername + "\t" + finalscore.ToString("n2") + Environment.NewLine;
               
            }
        }
    }
}
