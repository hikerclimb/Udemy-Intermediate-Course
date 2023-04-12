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

namespace RomanNumerals
{
    public partial class FrmRoman : Form
    {
        public FrmRoman()
        {
            InitializeComponent();
        }

		//This will be used to store all the Roman numeral representations
		//of the numbers from 1 to 3888 
		//... where the key is the roman numeral and the value is the arabic number
		Dictionary<string,int> Map = new Dictionary<string, int>();

		private void BtnRoman_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\roman.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;
			int n;

			//Fill up the Dictionary
			MapAllRoman();

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
					//Here we are trying to determine whether the
					//string we have read in is a valid representation of a integer
					//If it is convert it to Roman numeral 
					//... otherwise it's in Roman numeral format (it has letters) already and 
					//we need to convert it back to an integer
					//We don't really use the n variable but it is a necessary to use TryParse
					//... in essence n would be the integer representation of the string value
					//we just read in
					if (int.TryParse(line,out n) )
                    {
						TxtDisplay.Text += line +  " -> " + ToRoman(line)+  Environment.NewLine;        
                    }
					else
                    {
						TxtDisplay.Text += line + " -> " + Map[line] + Environment.NewLine;
                    }
					           
                }
            }
        }

        private string ToRoman(string num)
        {
            string ans = "";
            int x = int.Parse(num);

			// thousands:
			int T = x / 1000;
			switch (T)
			{
				case 1: ans = "M"; break;
				case 2: ans = "MM"; break;
				case 3: ans = "MMM"; break;
			}
			// hundreds:
			int H = (x % 1000) / 100;
			switch (H)
			{
				case 1: ans += "C"; break;
				case 2: ans += "CC"; break;
				case 3: ans += "CCC"; break;
				case 4: ans += "CD"; break;
				case 5: ans += "D"; break;
				case 6: ans += "DC"; break;
				case 7: ans += "DCC"; break;
				case 8: ans += "DCCC"; break;
				case 9: ans += "CM"; break;
			}
			// tens:
			T = (x % 100) / 10;
			switch (T)
			{
				case 1: ans += "X"; break;
				case 2: ans += "XX"; break;
				case 3: ans += "XXX"; break;
				case 4: ans += "XL"; break;
				case 5: ans += "L"; break;
				case 6: ans += "LX"; break;
				case 7: ans += "LXX"; break;
				case 8: ans += "LXXX"; break;
				case 9: ans += "XC"; break;
			}
			// units:
			int U = x % 10;
			switch (U)
			{
				case 1: ans += "I"; break;
				case 2: ans += "II"; break;
				case 3: ans += "III"; break;
				case 4: ans += "IV"; break;
				case 5: ans += "V"; break;
				case 6: ans += "VI"; break;
				case 7: ans += "VII"; break;
				case 8: ans += "VIII"; break;
				case 9: ans += "IX"; break;
			}

			return ans;
		}

		private void MapAllRoman()
        {
			//To convert from Arabic (regular numbers) to Roman numbers I simplying
			//call the ToRoman method
			//But to convert in the other direction I create a Dictionary
			//which will store all the possibilites ONCE.
			//By doing this, I don't need to run through all the possibilities for 
			//every Roman numeral I am trying to convert, I only do it once before
			//processing all the test cases.
			for (int i = 1; i <= 3888; i++)
            {
				Map[ToRoman(i.ToString())] = i;
            }
        }
    }
}
