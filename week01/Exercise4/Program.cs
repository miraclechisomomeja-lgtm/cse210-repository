using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                sum += item;
            }
            Console.WriteLine($"The sum is: {sum}");

            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int max = numbers[0];
            foreach (int item in numbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine($"The largest number is: {max}");

            int smallestPositive = int.MaxValue;

            foreach (int item in numbers)
            {
                if (item > 0 && item < smallestPositive)
                {
                    smallestPositive = item;
                }
            }
            if (smallestPositive != int.MaxValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered");
            }
            numbers.Sort();

            Console.WriteLine("The sorted list is:");

            foreach (int item in numbers)
            {
                Console.WriteLine(item);

            }
        }

        else
        {
            Console.WriteLine("No numbers were entered.");
        }

    }
}