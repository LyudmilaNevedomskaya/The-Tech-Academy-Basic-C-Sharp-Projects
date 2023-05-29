using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to String Assignment!!!");
            Console.WriteLine("************************************");
            Console.WriteLine("Enter your First Name.");
            string firstName = Console.ReadLine(); // get info from user

            Console.WriteLine("Enter your Last Name.");
            string lastName = Console.ReadLine(); // get info from user

            Console.WriteLine("Enter the city you live in.");
            string city = Console.ReadLine(); // get info from user

            // concatenate all strings and use ToUpper() method
            string welcomeCentence = "Hello " + firstName.ToUpper() + " " + lastName.ToUpper() + " from " + city.ToUpper();

            Console.WriteLine("************************************");
            Console.WriteLine(welcomeCentence);
            Console.WriteLine("************************************");


            // creating the string using String Builder
            StringBuilder sb = new StringBuilder();
            sb.Append("Lorem ipsum dolor sit amet.");
            sb.Append(" Second sentence");
            Console.WriteLine("Next you will see the text created using String Builer!");
            Console.WriteLine("<------------------------------------>");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
