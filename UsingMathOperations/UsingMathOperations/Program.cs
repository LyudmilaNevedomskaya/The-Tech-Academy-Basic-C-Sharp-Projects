using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Takes an input from the user, multiplies it by 50, then prints the result to the console.
            Console.WriteLine("Enter any number from 1 to 1000");
            string userInput = Console.ReadLine();
            int num1 = Convert.ToInt32(userInput);
            int total1 = num1 * 50;
            Console.WriteLine(userInput + " multiplies by 50 equals: " + total1.ToString());
            Console.WriteLine("-------------------------------");
            Console.ReadLine();

            // 2. Takes an input from the user, adds 25 to it, then prints the result to the console
            Console.WriteLine("Enter any number from 1 to 1000");
            string userInput2 = Console.ReadLine();
            int num2 = Convert.ToInt32(userInput2);
            int total2 = num2 + 25;
            Console.WriteLine(userInput2 + " add 25 equals: " + total2.ToString());
            Console.WriteLine("-------------------------------");
            Console.ReadLine();

            // 3. Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("Enter any number from 1 to 1000");
            string userInput3 = Console.ReadLine();
            int num3 = Convert.ToInt32(userInput3);
            double num3float = (double)num3;
            double total3 = num3float / 12.5;
            Console.WriteLine(userInput3 + " divides by 12.5 equals: " + total3.ToString());
            Console.WriteLine("-------------------------------");
            Console.ReadLine();

            // 4. Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console
            Console.WriteLine("Enter any number from 1 to 100");
            string userInput4 = Console.ReadLine();
            int num4 = Convert.ToInt32(userInput4);
            bool total4 = num4 > 50;
            Console.WriteLine("Your input number " + userInput4 + " is greater than 50: " + total4.ToString());
            Console.WriteLine("-------------------------------");
            Console.ReadLine();

            // 5. Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).
            Console.WriteLine("Enter any number from 1 to 100");
            string userInput5 = Console.ReadLine();
            int num5 = Convert.ToInt32(userInput4);
            int total5 = num5 % 7;
            Console.WriteLine("Your input number " + userInput5 + " divides by 7 gives the remainder: " + total5.ToString());
            Console.WriteLine("-------------------------------");
            Console.ReadLine();
        }
    }
}
