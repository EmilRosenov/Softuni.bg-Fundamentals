using System;
using System.Collections.Generic;
using System.Linq;

namespace GausTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            //first + last, first + 1 + last - 1, first + 2 + last - 2,
            // … first + n, last - n.

            List<int> numbers = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();

            //Console.WriteLine("Here it is");
            //Console.WriteLine(string.Join(" ",numbers));

            int originalCount = numbers.Count;
            for (int i = 0; i < originalCount / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.Remove(numbers[numbers.Count - 1]);

            }

            Console.WriteLine(string.Join(" ", numbers));
            

        }
    }
}
