using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1. _jobTitle = "Disney Imagineer";
        job1. _company = "Walt Disney Imagineering";
        job1. _startYear = 2022;
        job1. _endYear = 2025;

        Job job2 = new Job();
        job2. _jobTitle = "Project Manager";
        job2. _company = "Amazon";
        job2. _startYear = 2023;
        job2. _endYear = 2024;

        Resume myResume = new Resume(); //using the sample.
        myResume. _name = "James Moriarty";

        myResume. _jobs.Add(job1);
        myResume. _jobs.Add(job2);

        myResume.Display();
    }
}