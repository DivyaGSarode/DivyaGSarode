using System;
using GCDFinder;

/// <summary>
/// Console application that reads two integers from command-line arguments
/// and prints their Greatest Common Divisor (GCD) using the Euclidean algorithm.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: dotnet run <number1> <number2>");
            Console.WriteLine("Example: dotnet run 48 18");
            Environment.Exit(1);
        }

        try
        {
            int num1 = int.Parse(args[0]);
            int num2 = int.Parse(args[1]);

            int gcd = GcdFinder.FindGCD(num1, num2);
            Console.WriteLine($"GCD of {num1} and {num2}: {gcd}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please provide valid integers");
            Environment.Exit(1);
        }
    }
}
