using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Create an abstract class with two string properties
    public abstract class Person
    {
        public string FirsrName { get; set; }
        public string LastName { get; set; }
        // give the class method SayName()
        public abstract void SayName();
    }
}
