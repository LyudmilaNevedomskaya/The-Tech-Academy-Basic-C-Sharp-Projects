using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Person 1");
            Console.WriteLine("Enter Hourly Rate");
            // takes an input of hourly rate from person 1
            int person1HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hours worked per week");
            // takes an input of how many hors per week person 1 works
            int person1HoursPerWorkedWeek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            // calculate annual salary for person 1
            int annualPeson1 = person1HourlyRate * person1HoursPerWorkedWeek * 52;


            Console.WriteLine("Person 2");
            Console.WriteLine("Enter Hourly Rate");
            // takes an input of hourly rate from person 2
            int person2HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hours worked per week");
            // takes an input of how many hors per week person 2 works
            int person2HoursPerWorkedWeek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            // calculate annual salary for person 2
            int annualPerson2 = person2HourlyRate * person2HoursPerWorkedWeek * 52;

            // displaying the annual salaries for person 1 and 2
            Console.WriteLine("Annual salary of Person 1: " + annualPeson1.ToString());
            Console.WriteLine("Annual salary of Person 2: " + annualPerson2.ToString());
            Console.WriteLine("-----------------------------------");

            // compare if the person 1 earns more than person 2 per year
            bool compare = annualPeson1 > annualPerson2;
            Console.WriteLine("Person 1 makes more money than Person 2: " + compare.ToString());
            
            Console.WriteLine("THE END");
            Console.WriteLine("***************************");
            Console.ReadLine();
        }
    }
}
