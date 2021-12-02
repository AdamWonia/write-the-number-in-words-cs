using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadNumber();
            PrintNumberInWord(number);
            Console.ReadKey();
        }
        /// <summary>
        /// Get number from user between -1000 and 1000
        /// </summary>
        /// <returns>Return given number</returns>
        public static int ReadNumber()
        {
            int inputNumber = 0;
            bool continueFlag = true;

            Console.WriteLine("Insert an integer between -1000 and 1000:");
            while (continueFlag)
            {
                try
                {
                    inputNumber = int.Parse(Console.ReadLine());
                    if (inputNumber > 1000 || inputNumber < -1000)
                        Console.WriteLine("Wrong number! Try again :)");
                    else
                        continueFlag = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input number! Try again");
                }
            }
            return inputNumber;
        }
        /// <summary>
        /// Print given number in words
        /// </summary>
        /// <param name="number">Number to print in words</param>
        public static void PrintNumberInWord(int number)
        {
            // Arrays with string numbers:
            // Digits from 0 to 9:
            String[] digits = new String[10];
            digits[0] = "zero";
            digits[1] = "one";
            digits[2] = "two";
            digits[3] = "three";
            digits[4] = "four";
            digits[5] = "five";
            digits[6] = "six";
            digits[7] = "seven";
            digits[8] = "eight";
            digits[9] = "nine";

            // Numbers from 10 to 20:
            String[] numbers10To20 = new String[10];
            numbers10To20[0] = "ten";
            numbers10To20[1] = "eleven";
            numbers10To20[2] = "twelve";
            numbers10To20[3] = "thirteen";
            numbers10To20[4] = "fourteen";
            numbers10To20[5] = "fifteen";
            numbers10To20[6] = "sixteen";
            numbers10To20[7] = "seventeen";
            numbers10To20[8] = "eighteen";
            numbers10To20[9] = "nineteen";

            // Tens from 20 to 90;
            String[] tens = new String[8];
            tens[0] = "twenty";
            tens[1] = "thirty";
            tens[2] = "fourty";
            tens[3] = "fifty";
            tens[4] = "sixty";
            tens[5] = "seventy";
            tens[6] = "eighty";
            tens[7] = "ninety";

            // Hundreds from 100 to 900:
            String[] hundreds = new String[9];
            hundreds[0] = "one hundred and";
            hundreds[1] = "two hundred and";
            hundreds[2] = "three hundred and";
            hundreds[3] = "four hundred and";
            hundreds[4] = "five hundred and";
            hundreds[5] = "six hundred and";
            hundreds[6] = "seven hundred and";
            hundreds[7] = "eight hundred and";
            hundreds[8] = "nine hundred and";

            // Thousands:
            String[] thousands = new String[1];
            thousands[0] = "thousand";

            // Chech given number sign:
            if (number >= 0)
                Console.Write("Given number is: ");
            else
                Console.Write("Given number is: minus ");

            // Get absolute value:
            number = Math.Abs(number);
            // Print the number in words:
            if (number >= 0 && number < 10)
                Console.Write(digits[number]);
            if (number >= 10 && number < 20)
                Console.Write(numbers10To20[number - 10]);
            if (number >= 20 && number < 100)
            {
                // Divide into tens and unities:
                int t = (int)Math.Floor((decimal)number / 10);
                int u = number - t * 10;
                if (u == 0)
                    Console.WriteLine(tens[t - 2]);
                else
                    Console.WriteLine(tens[t - 2] + " " + digits[u]);
            }
            if (number >= 100 && number < 1000)
            {
                // Divide into hundreds, tens and unities:
                int h = (int)Math.Floor((double)number / 100);
                int t = number - h * 100;
                if (t == 0)
                    Console.WriteLine(hundreds[h - 1]);
                else if (t >= 0 && t < 10)
                    Console.WriteLine(hundreds[h - 1] + " " + digits[t]);
                else if (t >= 10 && t < 20)
                    Console.WriteLine(hundreds[h - 1] + " " + numbers10To20[t - 10]);
                else if (t >= 20 && t < 100)
                {
                    int tt = (int)Math.Floor((double)t / 10);
                    int u = t - tt * 10;
                    if (u == 0)
                        Console.WriteLine(hundreds[h - 1] + " " + tens[tt - 2]);
                    else
                        Console.WriteLine(hundreds[h - 1] + " " + tens[tt - 2] + " " + digits[u]);
                }
            }
            if (number == 1000)
                Console.WriteLine(thousands[0]);
        }
    }
}