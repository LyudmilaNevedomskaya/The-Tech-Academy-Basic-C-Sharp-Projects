using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicCarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Car Insuranse Application!!!");
            Console.WriteLine("-------------------------------------------");
            // get inputs from user
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (type Yes or No)");
            string isHaveDUI = Console.ReadLine().ToLower();
            bool haveDUI = isHaveDUI == "yes";
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTicketsAmount = Convert.ToInt32(Console.ReadLine());

            // using boolean operators check if user qualified for the insurance
            bool qualified = (userAge > 15) && !haveDUI && (speedTicketsAmount < 3);
            Console.WriteLine("Qualified? " + qualified);
            Console.ReadLine();

        }
    }
}
