using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1
            // one-dimensional array of strings
            string[] myArr = { "one ", "two ", "three ", "four ", "five", "six" };

            // ask the user to input some text
            Console.WriteLine("Please enter some text:");
            Console.WriteLine("----------------------------------");
            string someText = Console.ReadLine();

            // create a loop that iterates through each string in the array and adds the user's text input to the end of each string
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = myArr[i] + someText;
            }

            // create a loop that prints off each string in the array one at a time
            foreach (string word in myArr)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine(word);
            }

            Console.WriteLine("**********************************************");

            // Assignment Part 2
            // create an infinite loop
            //while (true)
            //{
            //    //Do My Loop Stuff
            //    Console.WriteLine("I am infinite loop!!!!");
            //};
            // in order to escape infinite loop we need to add counting variable and change the condition
            Console.WriteLine("Enter any number from 5 to 15");
            int userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum < 5 || userNum > 15)
            {
                Console.WriteLine("You entered wrong number!!!");
            } else
            {
                int count = 0;
                while (count < userNum)
                {
                    Console.WriteLine("Hello Friend!!!");
                    count++;
                }
            }

            Console.WriteLine("**********************************************");
            // Assignment Part 3
            // A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator
            Console.WriteLine("Enter any number from 5 to 55");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            if (userNum1 < 5 || userNum1 > 55)
            {
                Console.WriteLine("You entered wrong number!!!");
            }
            else
            {
                int count = 0;
                while (count < userNum1)
                {
                    Console.WriteLine("Number: " + count.ToString());
                    count++;
                }
            }
            Console.WriteLine("----------------------------------");
            // A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operato
            
            int[] tryWin = { 75, 26, 38, 95, 84, 67, 99, 100};
            Console.WriteLine("Enter any number from 30 to 100");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            if (userNum2 <= 29 || userNum2 >= 101)
            {
                Console.WriteLine("You entered wrong number!!!");
            }
            else
            {
                foreach (int num in tryWin)
                {
                    if (num <= userNum2)
                    {
                        Console.WriteLine(num);
                    }
                }
            }


            Console.WriteLine("**********************************************");
            // Assignment Part 4
            // A list of strings where each item in the list is unique.
            List<string> uniqueList = new List<string>() { "mother", "father", "sister", "brother", "uncle", "aunt" };
            Console.WriteLine("Enter any family member");
            string famMember = Console.ReadLine().ToLower();

            // A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            for (int i = 0; i < uniqueList.Count; i++)
            {
                if (uniqueList[i] == famMember)
                {
                    Console.WriteLine("The index of word " + famMember + " is " + i);
                    break; // code that stops the loop from executing once a match has been found
                }
                if (!uniqueList.Contains(famMember)) // tell the user their input is not on the list
                {
                    Console.WriteLine("Your input is not on the list");
                    break;
                }
                 
            }

            Console.WriteLine("**********************************************");
            // Assignment Part 5
            // A list of strings that has at least two identical strings in the list
            List<string> notUniqueList = new List<string>() { "apple", "banana", "lemon", "grapes", "orange", "apple", "peach", "pineaple" };
            Console.WriteLine("Enter any fruit");
            string userFruit = Console.ReadLine().ToLower();
            for (int i = 0; i < notUniqueList.Count; i++)
            {
                // Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen
                if (notUniqueList[i] == userFruit)
                {
                    Console.WriteLine("The index of word " + userFruit + " is " + i);
                    
                }
                if (!notUniqueList.Contains(userFruit)) // tell the user their input is not on the list
                {
                    Console.WriteLine("Your input is not on the list");
                    break;
                }

            }


            Console.WriteLine("**********************************************");
            // Assignment Part 6
            // Create a list of strings that has at least two identical strings in the list
            List<string> doubleNotUniqueList = new List<string>() { "apple", "banana", "lemon", "grapes", "orange", "apple", "peach", "pineaple", "cherry", "kiwi", "apple" };
            List<string> repeatCheck = new List<string>();

            foreach (string fruit in doubleNotUniqueList)
            {
                Console.WriteLine(fruit);
                if (repeatCheck.Contains(fruit))
                {
                    Console.WriteLine("This item has been repeated");
                }
                else
                {
                    Console.WriteLine("This is unique item!!!");
                }
                repeatCheck.Add(fruit);
            }


            Console.ReadLine();
        }
    }
}
