using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the MathMethod
            MathMethod mathMeth = new MathMethod();
            // method where input as an integer
            Console.WriteLine(mathMeth.AddingNumbers(5));
            // method where input as a decimal
            Console.WriteLine(mathMeth.AddingNumbers(5.5m));
            // method where input as a string
            Console.WriteLine(mathMeth.AddingNumbers("5"));

            Console.ReadLine();
        }
    }
}
