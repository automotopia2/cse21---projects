using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int largest_num = 0;
        int entered_num = 999;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a number below to add to the list. Enter 0 when you are complete.");
        while (entered_num != 0)
        {
            entered_num = int.Parse(Console.ReadLine());
            numbers.Add(entered_num);
            sum = sum + entered_num;
            if (largest_num <= entered_num)
            {
                largest_num = entered_num;
            }
        }
        Console.WriteLine($"The sum of the numbers: {sum}");
        Console.WriteLine($"The average of numbers: {sum / numbers.Count}");
        Console.WriteLine($"The largest number: {largest_num}");
        Console.WriteLine($"Total numbers entered: {numbers.Count - 1}");
    }
}