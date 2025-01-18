using System;
using System.Collections.Generic;
using System.IO; //we use this for input and output, ergo reading and writing files

public class Journal
{
    public List<Entry> Entries;

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response, string firstName, string lastName)
    {
        var entry = new Entry(prompt, response, firstName, lastName); //var is variable!
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, append:true)) // so it won't overwrite entries
        {
            foreach (var entry in Entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._prompt} | {entry._response} | {entry._firstName} {entry._lastName}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            Entries.Clear(); // clear existing entries before loading up
            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var parts = line.Split(" | ");
                if (parts.Length >=5)
                {
                    var date = parts[0];
                    var prompt = parts[1];
                    var response = parts[2];
                    var firstName = parts[3];
                    var lastName = parts[4];

                    var entry = new Entry(prompt, response, firstName, lastName) {_date = date};
                    Entries.Add(entry);
                }

                else
                {
                    Console.WriteLine($"{line}");
                }
            }

            Console.WriteLine("Journal loaded succesffully.");

        }
        else
        {
            Console.WriteLine("Is the file in the room with us? No. nope.");
        }

    }
}