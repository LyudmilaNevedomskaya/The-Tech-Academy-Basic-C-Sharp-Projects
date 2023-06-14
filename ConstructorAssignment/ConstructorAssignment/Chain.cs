using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Chain
    {
        // constructor if one parameter, a float, is provided
        public Chain (float num1) : this(num1, "Mila")
        {
            Console.WriteLine(num1 + " and your dfault name is " + Name);
        }
        // constructor if one parameter, a string, is provided
        public Chain(string name1) : this(42, name1)
        {
            Console.WriteLine(name1 + " and your default favorite number is " + Num);
        }
        // constructor if both parameters, a float and a string, are provided
        public Chain (float num, string name)
        {
            Name = name;
            Num = num;
        }

        string Name { get; set; }
        float Num { get; set; }
    }
}
