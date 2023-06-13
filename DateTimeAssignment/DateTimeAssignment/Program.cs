using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints the current date and time to the console.
            Console.WriteLine("The current time is: " + DateTime.Now);
            // Asks the user for a number.
            Console.WriteLine("\nEnter a number to see what the time will be in that many hours: ");
            float userNumber = float.Parse(Console.ReadLine());
            // Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2
            Console.WriteLine("{0} + {1} hour(s) = {2}", DateTime.Now, userNumber, DateTime.Now.AddHours(userNumber));
        }
    }
}
