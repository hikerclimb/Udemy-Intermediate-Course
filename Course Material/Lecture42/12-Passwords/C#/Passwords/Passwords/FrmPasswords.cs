using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Passwords
{
    public partial class FrmPasswords : Form
    {
        public FrmPasswords()
        {
            InitializeComponent();
        }

        private void BtnPasswords_Click(object sender, EventArgs e)
        {
            string password;


            bool finished = false;

            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\passwords.txt";

            StreamReader r = new StreamReader(f);

            while (!finished)
            {
                password = r.ReadLine();
                if (password == null)
                {
                    finished = true;
                }
                else
                {
                    TxtDisplay.Text += "Password " + password + " strength is " + PasswordStrength(password) + Environment.NewLine;
                }

            }

            r.Close();          
        }

        private int PasswordStrength(string p)
        {
            int strength = 0;

            strength = ApplyRules012(strength, p);
            strength = ApplyRules345(strength, p);

            //rule 6: +1 for every two-consecutive chars of != type
            for (int i = 0; i < p.Length - 1; i++)
            {
                if (CharacterType(p.Substring(i,1)) != CharacterType(p.Substring(i+1,1)))
                {
                    strength+=1;
                }

            }


            return strength;
        }

        private int CharacterType(string c)
        {
            char tempc = Convert.ToChar(c);

            //cant say character>="a" must convert it to type char first
            if ( (tempc>='a' && tempc <='z') || (tempc>='A' && tempc<='Z'))
            {
                return 0;
            }
            else if (tempc>='0' && tempc <='9')
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }

        private int ApplyRules012(int s, string pw)
        {
            //rule 0: start at 0
            s = 0;

            //rule 1: +10 if length >=8
            if (pw.Length >= 8)
                s += 10;

            //rule 2: +1 for every two chars further than 8
            if (pw.Length >= 8)
                s += (pw.Length - 8) / 2;

            return s;

        }

        private int ApplyRules345(int s, string pw)
        {
            //rules 3,4,5 contains UPPERCASE, lowercase, numeric,special
            Boolean containsUpper = false;
            Boolean containsLower = false;
            Boolean containsSpecial = false;
            Boolean containsNumeric = false;

            for (int i = 0; i < pw.Length; i++)
            {

                string temps = pw.Substring(i,1);
                char tempc = Convert.ToChar(temps);

                containsLower = containsLower || (tempc >= 'a' && tempc <= 'z');
                containsUpper = containsUpper || (tempc >= 'A' && tempc <= 'Z');
                containsNumeric = containsNumeric || (tempc >= '0' && tempc <= '9');
                containsSpecial = containsSpecial || (CharacterType(temps)==2);
                                
            }
                
            //rule 3: +1 if contains both upper and lower
            if (containsUpper && containsLower)
                s += 1;

            //rule 4: +1 if contains numeric
            if (containsNumeric)
                s += 1;

            //rule 5: +1 if contains special
            if (containsSpecial)
                s += 1;

            return s;

        }
    }
}
