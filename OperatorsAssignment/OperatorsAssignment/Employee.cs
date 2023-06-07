using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    // Create an Employee class with Id, FirstName and LastName propertie
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator == (Employee a, Employee b)
        {
            if (a.Id == b.Id) return true;
            else return false;
        }
        public static bool operator != (Employee a, Employee b)
        {
            if (a.Id != b.Id) return true;
            else return false;
        }
    }
}
