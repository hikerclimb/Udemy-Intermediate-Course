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

namespace TelephoneHelper
{
    public partial class FrmTelephone : Form
    {
        public FrmTelephone()
        {
            InitializeComponent();
        }

        string[] lines;
        char[] c;

        private void BtnTelephone_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\phone.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            bool finished = false;

            while (!finished)
            {
                string NewNumber = "";

                WholeLine = r.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                    NewNumber += "The real phone number is ";

                    string wTemp = WholeLine.ToUpper();
                    lines = wTemp.Split('-');

                    for (int i = 0; i < 4; i++)
                    {
                        //cant say  things like character>="0" or character <="9" 
                        //must convert it to type char first

                        c = lines[i].ToCharArray();

                        for (int j=0; j<c.Length;j++)
                        {
                            if (c[j] > '9' || c[j] <'0')  
                            {
                                if (c[j] <= 'C' && c[j] >= 'A')
                                    c[j] = '2';
                                else if (c[j] <= 'F' && c[j] >= 'D')
                                    c[j] = '3';
                                else if (c[j] <= 'I' && c[j] >= 'G')
                                    c[j] = '4';
                                else if (c[j] <= 'L' && c[j] >= 'J')
                                    c[j] = '5';
                                else if (c[j] <= 'O' && c[j] >= 'M')
                                    c[j] = '6';
                                else if (c[j] <= 'S' && c[j] >= 'P')
                                    c[j] = '7';
                                else if (c[j] <= 'V' && c[j] >= 'T')
                                    c[j] = '8';
                                else if (c[j] <= 'Z' && c[j] >= 'W')
                                    c[j] = '9';
                            }
                        }

                        //converting char array to string .. 
                        //can't concatenate the char type back into the string
                        string s = new string(c);

                        if (i<=2)
                        {
                            NewNumber += s + "-";
                        }
                        else
                        {
                            NewNumber += s;
                        }
                        
                    }

                    TxtDisplay.Text += NewNumber + Environment.NewLine;
                }
            }
        }
    }
}
