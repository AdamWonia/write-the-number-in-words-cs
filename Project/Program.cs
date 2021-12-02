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
            Console.WriteLine(ReadNumber());


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

            Console.WriteLine("\nInsert an integer between -1000 and 1000:");
            while (continueFlag)
            {
                inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber > 1000 || inputNumber < -1000)
                    Console.WriteLine("Wrong number! Try again :)");
                else
                    continueFlag = false;
            }
            return inputNumber;
        }



    }
}