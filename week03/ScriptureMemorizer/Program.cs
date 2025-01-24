using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        // Reference reference = new Reference("Proverbs", 3, 5, 6);
        // string text = "Trust in the Lord with all your heart and lean not on your own understanding.";

        // Exceeding requirements - Scripture library (located below), Get Hint (located in Word.cs)

        // Make way for Scripture library
        List<Scripture> scripture = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16),"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have eternal life."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("Matthew", 5, 16), "Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.")
        };

        Console.WriteLine("Are you ready to memorize?\nA random scripture will be selected for you.\nPress ENTER to begin.");
        Console.ReadLine();

        // Pick random in library
        Random random = new Random();
        Scripture selectedScripture = scripture[random.Next(scripture.Count)];

        while (true)
        {
            selectedScripture.Display();

            if (selectedScripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden! Great job memorizing.");
                break;
            }

            Console.WriteLine("\nPress ENTER to hide words, type HINT to reveal the first letter of hidden words, or type QUIT to exit.");
            string input = Console.ReadLine();

            if (input.ToUpper() == "QUIT") // Python nostalgia (it's only been two months :P)
            {
                break;
            }
            else if (input.ToUpper() == "HINT")
            {
                selectedScripture.Display(showHint: true);
                Console.WriteLine("\nPess ENTER to continue..");
                Console.ReadLine();
            }
            else
            {
            selectedScripture.HideRandomWords(3, hideOnlyVisible: true); // Hide 3 words at a time..
            }
        }
    }
}