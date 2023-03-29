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

namespace TelephoneEncrypt
{
    public partial class FrmEncrypt : Form
    {
        public FrmEncrypt()
        {
            InitializeComponent();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\telephone.txt";

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
                   
                     TxtDisplay.Text += "The Encrypted Number is " + Encrypt(line) +  Environment.NewLine;
                    
                }
            }
        }

        private string Encrypt(string tel)
        {
            string c1 = ""; //intermediate new number
            string finalcode = ""; //final coded number

            //loop through entire number
            for (int i=0;i< tel.Length;i++)
            {
                int newdigit = (int.Parse(tel.Substring(i, 1)) + 7) % 10; //modify each digit by adding 7 and then working out the  
                c1 = c1 + newdigit.ToString();                            //remainder when dividing by 10
            }

            //final coded number where digits are re-arranged so that 
            //first and third digits are swapped
            //second and fourth digits are swapped
            finalcode = c1.Substring(2, 1) + c1.Substring(3, 1) + c1.Substring(0, 1) + c1.Substring(1, 1);

            return finalcode;
        }
    }
}
