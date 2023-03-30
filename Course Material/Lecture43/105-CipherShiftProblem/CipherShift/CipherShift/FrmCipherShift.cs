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
using System.Text.RegularExpressions;

namespace CipherShift
{
    public partial class FrmCipherShift : Form
    {
        public FrmCipherShift()
        {
            InitializeComponent();
        }

        string[] lines;

        private void BtnShift_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Encryption/Decryption Results" + Environment.NewLine + Environment.NewLine;


            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\secret.txt";

            StreamReader r = new StreamReader(f);

            string WholeLine;
            bool finished = false;

            int encryptShift;
            int decryptShift;
            int number;
            

            while (!finished)
            {
                WholeLine = r.ReadLine();

                if (WholeLine == null)
                {
                    finished = true;
                }
                else
                {
                    lines = WholeLine.Split(' ');

                    encryptShift = int.Parse(lines[0]);
                    decryptShift = int.Parse(lines[1]);    

                    number = int.Parse(r.ReadLine());

                    TxtDisplay.Text += "Encrypt Shift " + encryptShift.ToString() + " " + "Decrypt Shift " + decryptShift.ToString() + " " 
                        + "Original Number " + number.ToString() + " " +   Environment.NewLine;
                    EncryptDecrypt(encryptShift, decryptShift, number);
                }

            }
        }

        private void EncryptDecrypt(int eshift,int dshift,int n)
        {
            int[] numbers ;
            string sn = n.ToString();
            numbers= new int[sn.Length];

            string encrypted = "";
            string decrypted = "";

            for (int i=0;i<sn.Length;i++)
            {
                numbers[i] = int.Parse(sn.Substring(i, 1));
            }

            for (int i=0;i<numbers.Length;i++)
            {
                numbers[i] = numbers[i] + eshift;
                while (numbers[i] >=10)
                {
                    numbers[i] -= 10;
                }

                encrypted += numbers[i].ToString();
            }

            TxtDisplay.Text += "The number " + n.ToString() + " encrypted is " + encrypted + Environment.NewLine;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] - dshift;
                while (numbers[i] <0)
                {
                    numbers[i] += 10;
                }

                decrypted += numbers[i].ToString();
            }

            TxtDisplay.Text += "The number " + encrypted + " decrypted is " + decrypted + Environment.NewLine + Environment.NewLine + Environment.NewLine;
        }
    }
}
