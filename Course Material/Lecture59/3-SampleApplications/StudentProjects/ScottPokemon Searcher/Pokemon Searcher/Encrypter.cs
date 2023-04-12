using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Encrypter
    {
        //*********************VARIABLES*********************
        //string alpha = alphabetical characters
        //string symbol = encrypted symbols
        //***************************************************

        static string alpha = "abcdefghijklmnopqrstuvwxyz1234567890";
        static string symbol = "∞∆∫∑√≠Ω€Θ©£¥§æΨ◊ė@¢°~¿ũƒβ‽†℗≈*зЮá|^&";

        public static void Encrypt(ref string text)
        {
            //random number generator
            Random r = new Random();

            string validate = "";
            int number;
            int total = 0;

            for (int i = 1; i <= 3; i++)
            {
                //random number
                number = r.Next(0, 9);
                //concatenates number to string
                validate += number.ToString();
                //adds number to total
                total += number;
                //random number
                number = r.Next(6, 9);
                //concatenates number to string
                validate += number.ToString();
                //adds square of number to total
                total += Convert.ToInt32(Math.Pow(number, 2));
            }

            //places total into middle of string
            //total will always be 3 digits
            validate = validate.Insert(3, total.ToString());

            //adds validation code on line one after number of members
            text = text.Substring(0, 1) + validate + text.Substring(1);

            //converts all characters into symbols
            for (int i = 0; i <= 35; i++)
                text = text.Replace(Convert.ToChar(alpha.Substring(i, 1)), Convert.ToChar(symbol.Substring(i, 1)));
        }

        public static bool Validate(string text)
        {
            //validity of validation code
            bool valid = false;

            //decrypts text
            text = Decrypt(text);

            //takes out validation code
            string numbers = text.Substring(1, 9);
            int validate;

            //adds up addition components of validation code
            validate = Convert.ToInt32(numbers.Substring(0, 1));
            validate += Convert.ToInt32(numbers.Substring(2, 1));
            validate += Convert.ToInt32(numbers.Substring(7, 1));

            //adds up expotential components of validation code
            validate += Convert.ToInt32(Math.Pow(Convert.ToDouble(numbers.Substring(1, 1)), 2));
            validate += Convert.ToInt32(Math.Pow(Convert.ToDouble(numbers.Substring(6, 1)), 2));
            validate += Convert.ToInt32(Math.Pow(Convert.ToDouble(numbers.Substring(8, 1)), 2));

            //compares total to 3 digits in the middle of the string
            if (validate.ToString() == numbers.Substring(3, 3))
                valid = true;

            //returns validity
            return valid;
        }

        public static string Decrypt(string text)
        {
            //converts encrypted symbols back to proper characters
            for (int i = 0; i <= 35; i++)
                text = text.Replace(Convert.ToChar(symbol.Substring(i, 1)), Convert.ToChar(alpha.Substring(i, 1)));

            return text;
        }
    }
}
