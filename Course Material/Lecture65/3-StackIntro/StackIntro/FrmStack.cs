using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace StackIntro
{
    public partial class FrmStack : Form
    {
        public FrmStack()
        {
            InitializeComponent();
        }

        private void BtnStack_Click(object sender, EventArgs e)
        {
            Stack nums = new Stack();
            Stack ops = new Stack();

            string expression = "5 + 10 + 15 + 20";

            //parse string 
            Calculate(nums, ops, expression);
            MessageBox.Show(nums.Pop().ToString());
           
        }

        //No built-in IsNumeric in C#
        private bool IsNumeric(string input)
        {
            bool isNum;
            double retNum;
            
            //TryParse ... a return value indicates whether the string could be converted to a double 
            //or not ... in this case
            isNum = Double.TryParse(Convert.ToString(input), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;

        }

        //A stack uses the principle LIFO (Last in First Out)
        private void Calculate(Stack N, Stack O, string exp)
        {
            string ch, token = "";

            for (int p = 0; p < exp.Length; p++)
            {
                ch = exp.Substring(p, 1);
                
                if (IsNumeric(ch))
                    token += ch;

                if (ch == " " || p == (exp.Length - 1))
                {
                    if (IsNumeric(token))
                    {
                        N.Push(token);
                        token = "";
                    }
                }
                else if (ch == "+" || ch == "-" || ch == "*" || ch == "/")
                {
                    O.Push(ch);
                }

                if (N.Count == 2)
                    Compute(N, O);
            }
        }

        private void Compute(Stack N,Stack O)
        {
            int oper1,oper2;
            string oper;

            oper1=Convert.ToInt32(N.Pop());
            oper2=Convert.ToInt32(N.Pop());
            oper = Convert.ToString(O.Pop());

            switch(oper)
            {
                case "+":
                    N.Push(oper2+oper1);
                    break;
                case "-":
                    N.Push(oper2-oper1);
                    break;
                case "*":
                    N.Push(oper2 * oper1);
                    break;
                case "/":
                    N.Push(oper2/oper1);
                    break;
            }
        }

        private void BtnStackApp_Click(object sender, EventArgs e)
        {
            //multiple Base Conversion using Stacks

            int num, baseNum;
            num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter decimal number to convert","","",200,200));
            baseNum = 2;

            MulBase(num, baseNum);            

        }

        //Good application for a stack
        //When we convert a decimal number to another form
        //we start with the right-most digits and work our way to the left.
        //Pushing each digit on the stack as we go works perfectly
        //because when we finish, the converted digits are in the 
        //correct order.
        private void MulBase(int n, int b)
        {
            Stack Digits = new Stack();

            do
            {
                Digits.Push(n % b);
                n /= b;
            }
            while (n != 0);

            while (Digits.Count > 0)
                TxtDisplay.Text += Digits.Pop().ToString();

        }
        
    }
}