using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        while (input != 0);

        int totalSum = 0;
        foreach (int number in numbers)
        {
            totalSum += number;
        }

        double average = (numbers.Count > 0) ? (double)totalSum / numbers.Count : 0;

        int max = (numbers.Count > 0) ? numbers[0] : 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}