using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string userCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            int userPage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”");
            string needHelp = Console.ReadLine();
            // converting strint into boolean
            bool needHelpBool = bool.Parse(needHelp);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string userExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string userFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int userHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name: " + userName);
            Console.WriteLine("Your course: " + userCourse);
            Console.WriteLine("Your page: " + userPage);
            Console.WriteLine("Need help: " + needHelp);
            Console.WriteLine("Your experience: " + userExperience);
            Console.WriteLine("Feedback: " + userFeedback);
            Console.WriteLine("Ours spent: " + userHours);
            Console.WriteLine("Tthank you " + userName + "! HAVE A NICE DAY!!!");
            Console.ReadLine();


            
        }
    }
}
