using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mini Exercise 2: Top 3 Numbers");
        Console.WriteLine("------------------------------");

        Mini_TopThree();

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void Mini_TopThree()
    {
        // TODO:
        // 1. Create the list of numbers.
        var numbers = new List<int>{ 10, 12, 65, 23, 5, 9, 78, 23 };
        
        // 2. Print the original list.
        Console.WriteLine($"Original list: ");
        Console.WriteLine(string.Join(",", numbers));
        // 3. Use OrderByDescending and Take(3).

        // 4. Convert the result to a list.
        var order = numbers.OrderByDescending(n => n).Take(3).ToList();
        // 5. Print the top 3 numbers.
        Console.WriteLine($"Top 3 Descending order: ");
        Console.WriteLine(string.Join(",", order));
    }
}
