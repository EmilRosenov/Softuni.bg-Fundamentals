using System;
using System.Linq;

namespace _6EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddSum = 0;
            int evenSum = 0;
            int difference = 0;
            int[] numbers = Console.ReadLine()
                            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
                else
                {
                    oddSum += numbers[i];
                }
            }

            difference = evenSum - oddSum;
            Console.WriteLine($"{difference}");
            

        }
    }
}
