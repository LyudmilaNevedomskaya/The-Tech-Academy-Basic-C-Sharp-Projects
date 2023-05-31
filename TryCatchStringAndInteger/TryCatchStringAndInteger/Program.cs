using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchStringAndInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            // create list of integers
            List<int> listOfNumbers = new List<int>() { 18, 25, 78, 196, 325, 724, 68, 329, 784 };

            // ask the user for a number
            Console.WriteLine("Pick a number");

            try
            {
                float userNumber = float.Parse(Console.ReadLine());
                if (userNumber == 0)
                {
                    Console.WriteLine("You cannot divide by zero!!!!");
                }
                else
                {
                    // divide each number in list by userNumber
                    foreach (int num in listOfNumbers)
                    {
                        float result;
                        result = num / userNumber;
                        Console.WriteLine(num + " divided by " + userNumber + " = " + result); // display the result to the screen
                    }
                }     
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            finally
            {
                Console.WriteLine("*********************************");
            }
            Console.WriteLine("The program has exited the try/catch block.");
            Console.ReadLine();
        }
    }
}
