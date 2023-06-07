using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Create another class, "Employee" and have it inherit from Person class
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        // Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirsrName + " " + LastName); 
        }
        public void Quit(Person person)
        {
            Console.WriteLine("Person: " + person);
        }
    }
}
