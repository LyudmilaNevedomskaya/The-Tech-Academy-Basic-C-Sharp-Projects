using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  instantiate the class
            MathOperation mathOp = new MathOperation();

            // Call the method in the class, passing in two numbers
            int result = mathOp.MathOperation1(5, 10);
            Console.WriteLine(result);

            // Call the method in the class, specifying the parameters by name
            int num1 = 10;
            int num2 = 20;
            result = mathOp.MathOperation1(num1, num2);
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
