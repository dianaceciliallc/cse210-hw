using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int smallest = int.MaxValue;
        int largest = int.MinValue;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        while ( number != 0 )
        {
            numbers.Add(number);
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());          
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            
            if ( numbers[i] > largest )
            {
                largest = numbers[i];
            }

            if ( numbers[i] > 0 && numbers[i] < smallest )
            {
                smallest = numbers[i];
            }
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        if ( smallest != int.MaxValue )
        {
            Console.WriteLine($"The smallest positive number is: {smallest}");
        }
        else
        {
            Console.WriteLine("There's no a smallest positive number in the list.");
        }

        Console.WriteLine($"The sorted list is:");

        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}