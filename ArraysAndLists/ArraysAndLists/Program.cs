using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {

        ////////CREATING AN ARRAY////////////////////
        //    int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 6000, 2500 };

        //Console.WriteLine(numArray[3]);
        //Console.WriteLine(numArray1[2]);

        ///////////   CREATING A LIST   /////////////////////
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        //List<string> stringList = new List<string>();
        //stringList.Add("Hello");
        //stringList.Add("Mila");
        //stringList.Remove("Hello");

        //Console.WriteLine(stringList[1]);


        // Create a one-dimensional Array of strings
        string[] stringArr = { "apple", "banana", "kiwi", "lemon", "grapes", "strawberry" };
        // Create a one-dimensional Array of integers.
        int[] intArr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 777 };

        //  Ask the user to select an index of the Array and then display the string at that index on the screen.
        Console.WriteLine("Enter a number from 0 to 5 to know the magic word!");
        int stringIndexNumber = Convert.ToInt32(Console.ReadLine());
        if (stringIndexNumber > 5 || stringIndexNumber < 0)
        {
            // Add in a message that displays when the user selects an index that doesn’t exist.
            Console.WriteLine("You entered the wrong number!!! And now you won't know the magic word!!!");
        } else
        {
            Console.WriteLine("Your magic word is: " + stringArr[stringIndexNumber].ToString());
        }

        Console.WriteLine("---------------------------------");

        //  Ask the user to select an index of the Array and then display the integer at that index on the screen.
        Console.WriteLine("Enter a number from 0 to 10 to know the magic number!");
        int intIndexNumber = Convert.ToInt32(Console.ReadLine());
        if (intIndexNumber > 10 || intIndexNumber < 0)
        {
            //  Add in a message that displays when the user selects an index that doesn’t exist.
            Console.WriteLine("You entered the wrong number!!! And now you won't know the magic number!!!");
        }
        else
        {
            Console.WriteLine("The magic number is: " + intArr[intIndexNumber].ToString());
        }

        // Create a list of strings.
        List<string> strList = new List<string>
        {   "Take the risk or lose the chance.",
            "I can and I will.",
            "No pressure, no diamonds.",
            "Don’t tell people your plans. Show them your results.",
            "Dream big. Pray bigger.",
            "If you want it, work for it.",
            "Leave no stone unturned.",
            "Broken crayons still color.",
            "Grow through what you go through.",
            "Do it with passion or not at all.",
            "When nothing goes right, go left."
        };

        // Ask the user to select an index of the list
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Enter a number from 0 to 10 to know the quote that will inspire you!");
        int quoteIndex = Convert.ToInt32(Console.ReadLine());
        if (quoteIndex > 10 || quoteIndex < 0)
        {
            Console.WriteLine("You entered the wrong number!!! And now you won't know the quote that will inspire you!!!");
        }
        else
        {
            Console.WriteLine(strList[quoteIndex]);
        }
        Console.ReadLine();

    }
    }

