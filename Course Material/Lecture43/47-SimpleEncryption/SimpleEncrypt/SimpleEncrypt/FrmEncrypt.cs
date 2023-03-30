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


namespace SimpleEncrypt
{
    public partial class FrmEncrypt : Form
    {
        public FrmEncrypt()
        {
            InitializeComponent();
        }

        string newmessages = "";
        string newkeystring = "";

        string[] messagearray = new string[60];
        string[] newmessage = new string[60];

        string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        int currentchar;
        int times;

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\encrypt.txt";

            StreamReader r = new StreamReader(f);

            string message;
            string key;
            
            bool finished = false;

            while (!finished)
            {
                key = r.ReadLine();

                if (key == null)
                {
                    finished = true;
                }
                else
                {
                    message = r.ReadLine();
                                     
                        TxtDisplay.Text += key + Environment.NewLine + message +  " " + Environment.NewLine +  EncodedMessage(key,message) +  Environment.NewLine + Environment.NewLine;
                }
            }
        }

        private string EncodedMessage(string k,string m)
        {
            string encoded = "";

            //go through each character in message to encode
            //a create a new string message without and blanks for special characters
            //only letters of the alphabet
            for (int i=0;i<=(m.Length-1);i++)
            {
               if (alpha.IndexOf(m.Substring(i,1))!=-1)
                {
                    newmessages += m.Substring(i, 1);
                }
            } 
            
            //now store each letter of this new formed message into an array
            for(int i=0;i<=(newmessages.Length-1);i++)
            {
                messagearray[i] = newmessages.Substring(i, 1);
            }

            //here we determine the number of rows in our encoded routine
            //column size will be key length
            //for example in the first case for "BANANAPEEL" and "ACT"
            //times = 10/3 = 3.333 = 3 + 1 = 4
            times = (int)newmessages.Length / k.Length;
            times++;  //round up

            for (int a=0;a<=times;a++)
            {
                newkeystring += k;
            }
            //newkeystring ="ACTACTACTACTACT"

            //get rid of extra letters from keystring
            newkeystring = newkeystring.Substring(0, newmessages.Length);
            //newkeystring ="ACTACTACTA" .... since newmessages.Length for "BANANAPEEL" is 10

            for (int b=0;b<=newmessages.Length-1;b++)
            {
                currentchar = alpha.IndexOf(messagearray[b]);               //find position of character in word to encode
                currentchar += alpha.IndexOf(newkeystring.Substring(b, 1)); //add the position of the character in key

                if (currentchar > 26)
                {
                    currentchar = currentchar % 26;                         //use modulo 26 arithmetic if over 26
                }

                newmessage[b] = alpha.Substring(currentchar, 1);            //store character of shifted code in array
            }

            for (int i=0;i<=newmessages.Length-1;i++)
            {
                encoded += newmessage[i];                                   //re-form encoded text
            }


            return encoded;
        }
    }
}
