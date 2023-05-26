using System;

namespace WhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a do while loop
            int count = 0;
            do
            {
                Console.WriteLine("Inside the loop! Count = " + count.ToString());
                count++; // add 1 to count each time
            }
            while (count < 10); // continue to loop until count reaches 10

            // this is a while loop
            int counting = 0;
            while (counting < 5)
            {
                Console.WriteLine("Counting numbers: " + counting.ToString());
                counting++;
            }
            Console.ReadLine();
        }


    }
}
