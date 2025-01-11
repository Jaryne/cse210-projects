using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");
        // Core requirements
        
        Console.Write("What is your grade percentage (e.g 89, 70)? ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        string letter = "";

        if (x >= 90)
        {
            letter =  "A";
        }

        else if (x >= 80)
        {
            letter =  "B";
        }

        else if (x >= 70)
        {
            letter =  "C";
        }

        else if (x >= 60)
        {
            letter =  "D";
        }
        
        else if (x < 60)
        {
            letter =  "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else
        {
            Console.WriteLine("Don't give up. Let's try again!");
        }
    }
}