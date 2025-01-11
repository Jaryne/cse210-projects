using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Guess My Number!

        Random rand = new Random();
        int userGuess = 0;
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes") //python with extra steps ngl
        {
            int magicNumber = rand.Next(1,101);
            int guessCount = 0;

            while (userGuess != magicNumber)
            {
                Console.Write("What's your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                guessCount++; //adds on each guess

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower!");
                }
                
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
                
                else if (userGuess == magicNumber)
                {
                    Console.WriteLine("You guessed it right!");
                    Console.WriteLine($"Guess count: {guessCount}");
                }
            }

            Console.WriteLine("Play again (yes/no)? ");
            playAgain = Console.ReadLine();

            userGuess = 0;

        }

        Console.WriteLine("Thanks for playing!");

    }
}