using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  instantiate two objects of the Employee class and assign values to their properties
            Employee emplOne = new Employee() { Id = 12345, FirstName = "Mila", LastName = "Smith" };
            Employee emplTwo = new Employee() { Id = 12345, FirstName = "Max", LastName = "Brown" };

            // compare the two Employee objects using the newly overloaded operators and display the results
            Console.WriteLine(emplOne == emplTwo ? $"{emplOne.FirstName} and {emplTwo.FirstName} have the same ID number: {emplOne.Id}" : $"The IDs are different!");

            Console.ReadLine();
        }
    }
}
