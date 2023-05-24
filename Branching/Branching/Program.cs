using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. \nPlease follow the instructions below. \n---------------------------------------------");

            // getting information about package weight
            Console.WriteLine("What is the weight of your package in kg?");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            // if the weight is more than 50, displaying a message
            if (packWeight > 50)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Package too heavy to be shipped via Package Express. \nHave a good day.");
            }
            else
            {
                // getting information about package width
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("What is the width of your package in cm?");
                int packWidth = Convert.ToInt32(Console.ReadLine());

                // getting information about package height
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("What is the height of your package in cm?");
                int packHeight = Convert.ToInt32(Console.ReadLine());

                // getting information about package length
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("What is the length of your package in cm?");
                int packLength = Convert.ToInt32(Console.ReadLine());

                // If the dimensions total greater than 50, display the error message
                if ((packWidth + packHeight + packLength) > 50)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Package too big to be shipped via Package Express. \nHave a good day.");
                }
                else
                {
                    // calculating the quote
                    int userQuote = ((packWidth * packHeight * packLength) * packWeight) / 100;

                    // displaying the quote to user
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Your estimated total for shipping this package is: $" + userQuote.ToString() + ".00 \nThank you!");

                }

            }
                Console.ReadLine();

        }
    }
}
