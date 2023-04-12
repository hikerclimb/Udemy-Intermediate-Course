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

namespace SayNumber
{
    public partial class FrmSayNumber : Form
    {
        public FrmSayNumber()
        {
            InitializeComponent();
        }

        //cannot use int here for MAX since int has upper limit of 2,147,483,647 ( signed 32 bit)
        //We use long here which in unsigned 64 bit equals 18,446,744,073,709,551,615
        const long MIN = 0;
        const long MAX = 999999999999;

        //The Dictionary declaration is a Generic collection
        //that stores key-value pairs that we will use to help us "say" numbers
        Dictionary<int, string> words = new Dictionary<int, string>
        {
            {1,"one" },
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},

            {10, "ten"},
            {20, "twenty"},
            {30, "thirty"},
            {40, "forty"},
            {50, "fifty"},
            {60, "sixty"},
            {70, "seventy"},
            {80, "eighty"},
            {90, "ninety"}
        };

        //Here we create a generic List where we will use a simple association
        //of groups[0]=string.Empty groups[1]="thousand" .... etc
        List<string> groups = new List<string>
        { 
            string.Empty,
            "thousand",
            "million",
            "billion",
        };


        private void BtnSayNumber_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();            
            
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\numbers.txt";

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
                    TxtDisplay.Text += line + " -> " + InEnglish(long.Parse(line)) + Environment.NewLine;                    
                }
            }
        }

        private string InEnglish(long number)
        {
            //Best way to understand logic is to step through program (using F11)
            // with some of the sample data and hover over variables
            //Lots of interesting concepts including using Lists,Dictionaries and Stacks
            
            if (number<MIN)
            {
                return "Too Small";
            }
            if (number > MAX)
            {
                return "Too Big";
            }
            if (number ==0)
            {
                return "zero";
            }

            var groupIndex = 0;
            
            //A Stack uses the principle LIFO (Last in First Out)
            //We will PUSH separate parts of number being converted to text onto 
            //the Stack and before returning join (concatenate) all the layers ... top first ... down to bottom  
            var result = new Stack<string>();

            while (number >0)
            {
                var group = (int)(number % 1000); 

                if (group >0)
                {
                    var part= ConvertGroup( (int)(number % 1000)); 
                    
                    if (groupIndex >0)  //used with groups lists groupIndex 1 ...thousand 2 ...million 3 ... billion
                    {
                        result.Push(groups[groupIndex]);
                    }

                    result.Push(part); //place part on the result Stack
                }

                number = number / 1000; //using long type variables so no remainder when divided
                groupIndex++;

            }

            //Join(string,ojbect)
            //Takes contents of stack from top first bottom last and joins them all
            return string.Join(" ", result);
                                            
        }

        private string ConvertGroup(int number)
        {
            var result = new List<string>();
            
            var hundreds = GetHundreds(number);

            if (hundreds != null)
                result.Add(hundreds);

            var rest = GetRest(number);

            if (rest != null)
                result.Add(rest);

            return string.Join(" ", result);
        }

        private string GetHundreds(int number)
        {
            var hundreds = (number - (number % 100)) / 100; 
            return hundreds > 0 ? words[hundreds] + " hundred" : null;
            //condition ? consequent:alternative
        }

        private string GetRest(int number)
        {
            var ones = number % 10;
            var tens = (number % 100) - ones;

            if (tens > 0)
                return GetTens(tens, ones);

            if (ones > 0)
                return words[ones];

            return null;
        }

        private string GetTens(int tens, int ones)
        {
            if (tens==10 && ones >0)
            {
                if (ones == 1)
                    return "eleven";

                if (ones == 2)
                    return "twelve";

                return words[ones] + "teen";
            }

            if (ones >0)
            {
                return words[tens] + "-" + words[ones];
            }

            return words[tens];
        }
    }
}
