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

namespace ListProblems
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        private void BtnProblem1_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\words.txt";

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
                    if (CheckAreCharactersUnique(line))
                    {
                        TxtDisplay.Text += line + " -> All The Characters Are Unique" + Environment.NewLine;
                    }
                    else
                    {
                        TxtDisplay.Text += line + "  -> Not All The Characters Are Unique" + Environment.NewLine;
                    }
                }
            }
        }

        private bool CheckAreCharactersUnique(string word)
        {
            // Obviously unique
            if (word == null || word.Length <= 1)
            {
                return true;
            }


            //var Background Info
            /*It’s easier to think of “var” as a short-hand version of declaring your variables.
            Instead of defining what Type your variable is twice, you get to do it once with “var.” Take the following traditional examples:

            // traditional variable declarations in C#
            // using primitives
            string name = "Chris";
            int month = 3;

            // using complex object
            Person student = new Person();
            The above declarations are fine; they work and are easy to read.However, why must we declare that “name” is a string, or month is a int, or “student” is a Person? Since we are assigning them an initial value on declaration, shouldn’t the compiler be able to tell what they they are implicitly?

            Actually, YES!!That is why the “var” keyword was introduced.Here are the same examples using the “var” keyword:

            // variable declarations using "var" in C#
            // using primitives
            var name = "Chris";
            var month = 3;

            // using complex object
            var student = new Person() */


            var CharacterList = new List<char>();

            
            for (int i = 0; i < word.Length; ++i)
            {
                char c = Convert.ToChar(word.Substring(i, 1));

                if (CharacterList.Contains(c))
                {
                    return false;
                }

                // Add all characters from word to new List, if char is already in List
                // return false immediately

                CharacterList.Add(c);
            }

            return true;
        }
    }
}
