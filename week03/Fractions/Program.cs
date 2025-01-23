using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction a1 = new Fraction();
        Fraction a2 = new Fraction(5);
        Fraction a3 = new Fraction(3,4);
        Fraction a4 = new Fraction(1,3);

        // Display fraction
        Console.WriteLine(a1.GetFraction());
        Console.WriteLine(a2.GetFraction());
        Console.WriteLine(a3.GetFraction());
        Console.WriteLine(a4.GetFraction());

        // Display decimal
        Console.WriteLine(a1.GetDecimal());
        Console.WriteLine(a2.GetDecimal());
        Console.WriteLine(a3.GetDecimal());
        Console.WriteLine(a4.GetDecimal());
    }
}