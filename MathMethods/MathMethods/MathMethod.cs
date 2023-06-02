using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    public class MathMethod
    {
        // method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer
        public int AddingNumbers(int number)
        {
            return number + 10;
        }

        // method that will take in a decimal, create a different math operation for it, then return the answer as an integer
        public int AddingNumbers(decimal number)
        {
            int result = Convert.ToInt32(number);
            return result + 20;
        }

        // method that will take in a string, create a different math operation for it, then return the answer as an integer
        public int AddingNumbers(string number)
        {
            int result = Convert.ToInt32(number);
            return result * 5;
        }
    }
}
