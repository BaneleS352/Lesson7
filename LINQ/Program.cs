using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mini Exercise 1: Safe Division");
        Console.WriteLine("------------------------------");

        Mini_SafeDivision();

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void Mini_SafeDivision()
    {
        try
        {
            // TODO:
            // 1. Ask for the numerator and denominator.
            // 2. Validate both inputs with int.TryParse.
            Console.WriteLine("Please enter a numerator: ");
            string? inputNumerator = Console.ReadLine();
            Console.WriteLine("Please enter a denominator: ");
            string? inputDenominator = Console.ReadLine();

            int denominator = int.Parse(inputDenominator);
            int numerator = int.Parse(inputNumerator);
            // 4. Use try/catch to divide the numbers.

            Console.WriteLine($"Divison: {numerator / denominator} ");

        }
        // 3. If input is invalid, show a friendly message and return.
        catch (ArgumentNullException)
        {
            Console.WriteLine("You entered an invalid value");
        }
        // 5. Catch DivideByZeroException and show a friendly message.
        catch (DivideByZeroException)
        {
            Console.WriteLine("Numbers cannot be divided by zero");
        }
        finally
        {
            Console.WriteLine("Done");
        }
        
        
        
    }
}