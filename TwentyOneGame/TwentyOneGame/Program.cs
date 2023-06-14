using System;
using System.IO;
using Cassino;
using Cassino.TwentyOneGame;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //// DateTime
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);

            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);
            //TimeSpan ageGraduation = yearOfGraduation - yearOfBirth;
            //// write text from program into a .txt file
            //string text = "Here is some text";
            //File.WriteAllText(@"C:\Users\milo4\Logs\log.txt", text);

            //// read some text from .txt file
            //string text1 = File.ReadAllText(@"C:\Users\milo4\Logs\log.txt");
            const string casinoName = "Grand Hotel and Casino";

            Guid identifier = Guid.NewGuid();

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name!", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer =="yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                // logging player Id in .txt file
                using (StreamWriter file = new StreamWriter(@"C:\Users\milo4\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivePlaying = true;
                while(player.IsActivePlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security!!! Kick this person out!!!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured! Please contact your System Administrator!!!");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the Casino. Bye for now.");
            Console.Read();
        }
        

    }
}
