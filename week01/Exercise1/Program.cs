using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for name.
        // Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // .WriteLine creates a newline after the question. .Write doesnt.

        Console.Write("What is your first name? "); 
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}