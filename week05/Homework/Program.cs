using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");


        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment sectionProblem = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "Problems 8-19");
        WritingAssignment title = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(assignment.GetSummary());

        // Math Assignment
        Console.WriteLine(sectionProblem.GetSummary());
        Console.WriteLine(sectionProblem.GetHomeworkList());

        // Writing Assignment
        Console.WriteLine(title.GetSummary());
        Console.WriteLine(title.GetWritingInformation());

    }
}