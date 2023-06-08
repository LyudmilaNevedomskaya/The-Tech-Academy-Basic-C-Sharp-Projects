using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of data type Number and assign an amount to it
            Number amount = new Number();
            amount.Amount = 15.5m;

            Console.WriteLine("This is a decimal number: " + amount.Amount);
            Console.ReadLine();
        }
    }
}
