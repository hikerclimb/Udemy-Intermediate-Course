using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LetterCount
{
    public partial class FrmLetterCount : Form
    {
        public FrmLetterCount()
        {
            InitializeComponent();
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            string sentence;
            sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            string letter;

            int LengthOfSentence = sentence.Length;

            for (int i = 0; i < LengthOfSentence; i++)
            {
                letter = sentence.Substring(i, 1);
                TxtResult.Text += letter + Environment.NewLine;
            }

        }

        private void BtnReverse_Click(object sender, EventArgs e)
        {
            string sentence;
            sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            string letter;

            int LengthOfSentence = sentence.Length;

            for (int i = LengthOfSentence-1; i >=0; i--)
            {
                letter = sentence.Substring(i, 1);
                TxtResult.Text += letter + Environment.NewLine;
            }

        }

        private void BtnLetterCount_Click(object sender, EventArgs e)
        {
            string sentence;
            sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            string letter;

            int counta=0;

            int LengthOfSentence = sentence.Length;

            for (int i = 0; i < LengthOfSentence; i++)
            {
                letter = sentence.Substring(i, 1);
                if (letter == "a")
                {
                    counta++;
                }
            }

            MessageBox.Show("The number of letter a\'s in the sentence is " + counta.ToString());

        }

        private void TxtProblem1_Click(object sender, EventArgs e)
        {
            string sentence;
            sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            string letter;

            int numberOfVowels = 0;

            int LengthOfSentence = sentence.Length;

            for (int i = 0; i < LengthOfSentence; i++)
            {
                letter = sentence.Substring(i, 1);
                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    numberOfVowels++;
                }
            }

            MessageBox.Show("The number of vowels(aeiou) in the sentence is " + numberOfVowels.ToString());

        }

        private void TxtProblem2_Click(object sender, EventArgs e)
        {
            string sentence;
            sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            string letter = "";

            int numberOfTimesTheAppearsInSentence = 0;

            int LengthOfSentence = sentence.Length;

            for (int i = 0; i < LengthOfSentence - 4; i++)
            {
                letter = sentence.Substring(i, 5);
                if (letter == " the ")
                {
                    numberOfTimesTheAppearsInSentence++;
                }
            }

            MessageBox.Show("The number of vowels(aeiou) in the sentence is " + numberOfTimesTheAppearsInSentence.ToString());
        }

        private void BtnProblem3_Click(object sender, EventArgs e)
        {
            string sentence;
            sentence = Microsoft.VisualBasic.Interaction.InputBox("Enter a sentence", "Strings", "", 200, 200);

            int LengthOfSentence = sentence.Length;

            string middleLetter = sentence.Substring(LengthOfSentence / 2, 1);

            if (LengthOfSentence % 2 == 0)
            {
                MessageBox.Show("must have odd number of letters");
            }
            else
            {
                MessageBox.Show("middle letter is: " + middleLetter);
            }
        }
    }
}