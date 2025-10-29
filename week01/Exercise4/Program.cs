using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        int max = 0;
        double average;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string textNumber = Console.ReadLine();
            number = int.Parse(textNumber);
            if (number != 0)
            {
                numbers.Add(number);
            }
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
        average = numbers.Average();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}