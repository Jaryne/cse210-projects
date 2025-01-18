using System;
using System.Collections.Generic; // we add this because we use List<>

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Journal Project.");

        var journal = new Journal();
        var prompts = new List<string>
        {
            "What was the best part of my day?",
            "Have I done any good in the world today?",
            "If I could redo one thing i did today, what would it be?",
            "What's the strangest thing I learned today?",
            "Who did I meet today?",
            "What made me smile today?",
            "If you could talk to yourself an hour ago, what would you say?",
            "How did we do today?"
        };

        bool running = true;
        while (running)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Pick an option: ");

            var choice = Console.ReadLine();

            switch (choice) // switch-case statement for the choices
            {
                case "1":
                    WriteNewEntry(journal, prompts);
                    break;
                
                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    SaveJournalToFile(journal);
                    break;
                
                case "4":
                    LoadJournalFromFile(journal);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Until next time!");
                    break;

                default:
                    Console.WriteLine("what? is that 1-5?");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal, List<string> prompts)
    {
        var random = new Random();
        var prompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Your response: ");
        var response = Console.ReadLine();

        // Part of Exceeding requirement**
        Console.WriteLine("Enter first name: ");
        var firstName = Console.ReadLine();
        Console.WriteLine("Enter last name: ");
        var lastName = Console.ReadLine();

        journal.AddEntry(prompt, response, firstName, lastName);
        Console.WriteLine("Your entry has been saved.");
    }

    static void SaveJournalToFile(Journal journal)
    {
        Console.Write("Enter filename to save journal: ");
        var filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    static void LoadJournalFromFile(Journal journal)
    {
        Console.Write("Enter filename to load the journal: ");
        var filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}