using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Random_Number_Generator_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guess;
            bool verification = false;
            bool PlayAgain = false;
            int tries = 0;
            string filePath = @"C:\Users\mytri\OneDrive\Desktop\School 22,23\IMS 22-23\Lernatelier 2\Projekte\Einarbeitungs Projekt\Random Number Generator 2.0\Random Number Generator 2.0\scoreboard.txt";

            //txt file into list 

            List <string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();



            while (PlayAgain == false)
            {
                //generate random number

                Random random = new Random();
                int randomNr = random.Next(1, 100);

                Console.WriteLine("Welcome to the number guesser. I have generated a random number, can you guess it???");
                Console.WriteLine("First please enter your name:");


                string playerName = Console.ReadLine();

                Console.WriteLine("Hello " + playerName + ".");


                //Loop 

                while (verification == false)
                {
                    Console.WriteLine("You can now try to guess my number.");

                    string playerGuess = Console.ReadLine();
                    guess = Convert.ToInt32(playerGuess);





                    //if guessed incorrectly

                    //hint system

                    if (guess > randomNr)
                    {
                        Console.WriteLine("The number you chose is incorrect. Try choosing a lower number.");
                        tries++;
                    }

                    else if (guess < randomNr)
                    {
                        Console.WriteLine("The number you chose is incorrect. Try choosing a higher number.");
                        tries++;
                    }




                    //if guessed correctly

                    else if (guess == randomNr)

                    {
                        Console.WriteLine("Congratulations " + playerName + " you guessed the number correctly. You only needed " + tries + " tries to figure it out.");

                        string score = Convert.ToString(tries);

                        lines.Add(playerName + ", " + tries);
                        File.WriteAllLines(filePath, lines);


                        Console.WriteLine("This is the scoreboard");
                        foreach (string line in lines)
                        { Console.WriteLine(lines); }


                        verification = true;

                    }
                }

                Console.WriteLine("Would you like to play again?");

                string playAgain = Console.ReadLine();

                if (playAgain == "y")
                {
                    PlayAgain = false;
                    verification = false;
                }

                else
                {
                    PlayAgain = true;
                }

            }
            
        }
    }
}
