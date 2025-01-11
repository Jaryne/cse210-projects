using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");
        // List<int> numbers = new List<int>();
        //List<string> words = new List<string>();

        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. (one number at a time)");

        do //trying this loop
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        if (numbers.Count > 0)
        {
            int sum = 0;
            int max = numbers[0];

            foreach (int num in numbers)
            {
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
        
            double average = (double)sum / numbers.Count;

            // Outputs
            Console.WriteLine($"Rhe sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("No valid number entered.");
        }
    }
}