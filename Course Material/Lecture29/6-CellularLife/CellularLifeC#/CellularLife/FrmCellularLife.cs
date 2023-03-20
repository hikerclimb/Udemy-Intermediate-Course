using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CellularLife
{
    public partial class FrmCellularLife : Form
    {
        public FrmCellularLife()
        {
            InitializeComponent();
        }

        int [] CurrentState  = new int[11];
        string[] lines;
        int minutes;


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSimulate_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text="Cellular Life Results" + Environment.NewLine+ Environment.NewLine;
                        
            
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\cells.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            int cl=0;
            int nc = 0;
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
                    cl++;

                    lines = WholeLine.Split(' ');
                    
                    minutes = int.Parse(lines[0]);

                    nc = lines.Length;

                    for(int cell=1;cell<nc;cell++)
                    {
                        CurrentState[cell] = int.Parse(lines[cell]);
                    }

                    for (int i = 1; i <= minutes; i++)
                    {
                        CurrentState = CalculateNextGeneration(CurrentState, nc-1);                    
                    }
                                
                    PrintGrid(CurrentState, nc-1,cl);

                }              
                
            }

            r.Close();
        }

        private void PrintGrid(int [] array,int size,int c)
        {
            
            TxtDisplay.Text+="#"+c.ToString()+": ";
            
            for (int i=1;i<=size;i++)
            {
                TxtDisplay.Text+= array[i]+" ";
            }
        
            TxtDisplay.Text+=Environment.NewLine;
        }

        private int CountNeighbors(int [] a  , int pos)
        {
            if (pos == 1)
            {
                return a[2];
            }
            else if (pos == 10)
            {
                return a[9];
            }
            else
            {
                return a[pos-1] + a[pos+1];
            }
        }

        private int[] CalculateNextGeneration(int []cstate ,int size)
        {
            int [] nextGen  = new int[11];
            int neighbors;
        
            for (int i=1;i<=size;i++)
            {            
                neighbors=CountNeighbors(cstate,i);
                
                if (neighbors <3 || neighbors >7)
                {
                    nextGen[i]=cstate[i]-1;
                }
                else if (neighbors ==3)
                {
                    nextGen[i]=cstate[i];
                }
                else
                {
                    nextGen[i]=cstate[i]+1;
                }
                    
                 
                 if (nextGen[i] < 0)
                 {
                    nextGen[i]=0;
                 }
                 else if (nextGen[i]>9)
                 {
                    nextGen[i]=9;
                 }
            
            }
        
            return nextGen;
        
        }
    }
}