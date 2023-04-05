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

namespace TheWinnerIs
{
    public partial class FrmWinner : Form
    {
        public FrmWinner()
        {
            InitializeComponent();
        }

        private void BtnWinner_Click(object sender, EventArgs e)
        {
            int c = 0;

            string[] lines = new string[2];
            String[] lines2 = new String[2];    

            string s = Application.StartupPath;
            string f = s + @"\winner.txt";

            StreamReader r = new StreamReader(f);

            StudentRecord[] rec = new StudentRecord[100];

            string WholeLine;

            while ((WholeLine = r.ReadLine()) != null)
            {
                c++;

                //**** Special case of Split Method *****
                
                String[] separator = {" "};
                
                Int32 cnt = 2; //Here we are splitting the string into a max number of substrings
                               //Takes care of 571 Clan 345 ... where the score is 571 and the name is Clan 345
                               //Otherwise we would have 3 separate split substrings
                               //we only want two ... score and name 

                lines2 = WholeLine.Split(separator, cnt, StringSplitOptions.RemoveEmptyEntries);

                rec[c] = new StudentRecord();
                rec[c].Score = int.Parse(lines2[0]);
                rec[c].StudentName = lines2[1];


                //This basic technique won't work in this situation
                //lines = WholeLine.Split(' ');                
                //rec[c] = new StudentRecord();
                //rec[c].Score = int.Parse(lines[0]);
                //rec[c].StudentName = lines[1];

            }

            r.Close();

            int n = c;

            TxtDisplay.Clear();

            Display(rec, n,"Original List");
            Sort(rec, n);
            Display(rec, n,"Sorted List");

        }

        private void Display(StudentRecord[] rec,int u,string title)
        {

            TxtDisplay.Text += title + Environment.NewLine;
            
            for (int i=1;i<=u;i++)
            {
                TxtDisplay.Text += rec[i].StudentName + " -> " + rec[i].Score + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine ;
        }

        private void Sort(StudentRecord[] rec, int u)
        {
            StudentRecord temp;

            //Simple Exchange Sort Technique
            for (int j = 1; j <= u - 1; j++)
            {
                for (int k = j + 1; k <= u; k++)
                {
                    if (rec[j].Score < rec[k].Score)
                    {
                        temp = rec[j];
                        rec[j] = rec[k];
                        rec[k] = temp;
                    }
                }
            }
        }

    }
}
