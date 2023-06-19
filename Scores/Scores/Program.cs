using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your name!");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\milo4\OneDrive\Документы\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;
            Console.WriteLine("\nStudent Score: ");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\n\nTotal of " + lines.Length + " students. \tAverage score is: " + avgScore);


            Console.WriteLine("\n\n\nPress any key to exit!");
            Console.ReadKey();
        }
    }
}
