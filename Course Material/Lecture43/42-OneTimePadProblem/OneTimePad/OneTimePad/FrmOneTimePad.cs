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

namespace OneTimePad
{
    public partial class FrmOneTimePad : Form
    {
        public FrmOneTimePad()
        {
            InitializeComponent();
        }

        private void BtnOneTimePad_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\code.txt";

            StreamReader r = new StreamReader(f);

            string pad;
            string sentence;
            int num;
            
            num = int.Parse(r.ReadLine());

            for (int i=1;i<=num;i++)
            {
                pad = r.ReadLine();
                sentence = r.ReadLine();

                string encryptedSentence = encrypt(sentence, pad);
                string decryptPad = decrypt(pad);
                string decryptedSentence = encrypt(encryptedSentence, decryptPad);


                TxtDisplay.Text += encryptedSentence + " " + Environment.NewLine;
                TxtDisplay.Text += decryptPad + Environment.NewLine;
                TxtDisplay.Text += decryptedSentence + Environment.NewLine + Environment.NewLine; 
            }
             
            
        }

        private string encrypt(string text,string key)
        {
            string encryptedWord = "";

            int sum;

            for (int ch=0;ch<=text.Length-1;ch++)
            {
                string s1 = text.Substring(ch, 1); //extract one letter at a time
                char c1 = Convert.ToChar(s1);      //convert it from a string to a char type
                                                   //so we can use the ascii value of the letter 
                string s2 = key.Substring(ch, 1);
                char c2 = Convert.ToChar(s2);

                sum = c1-97 + c2-97;               //need to move the ascii values down to numbers between 0 and 25 
                sum = sum % 26;                    //the ascii value of 'a' is 97 , 'b' is 98 .... etc  
                sum = sum + 97;                    //thats why we subtract 97 initially
                                                   //if the first sum is over 26 we work out the remainder 
                encryptedWord += (char)sum;        //...and then we take this final sum and add 97 to put it back to its
            }                                      //actually ascii value and finally we convert is back to a char
                                                   //so we can concatenate it and create the finaly coded word

            return encryptedWord;
        }

        private string decrypt(string key)
        {
            string decryptionKey = "";

            for (int ch=0;ch<=key.Length-1;ch++)
            {
                string s = key.Substring(ch, 1);
                char c = Convert.ToChar(s);
                int result = ((26 - (c - 97)) % 26) + 97; //c-97 scales letter down to 0-25 for necessary calculation
                                                          //+97 puts it back to proper ascii value for string concatentation
                decryptionKey += (char)result;
            }

            return decryptionKey;
        }
    }
}
